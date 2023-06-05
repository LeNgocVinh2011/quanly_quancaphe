using Cafe_manager.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cafe_manager
{
    /// <summary>
    /// Interaction logic for TableMng.xaml
    /// </summary>
    public partial class TableMng : UserControl
    {
        int pageNumber = 1;
        IPagedList<TBL_STATUS> list;
        TBL_STATUS tbl;
        int iD;
        DBCafe db = new DBCafe();
        public TableMng()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            loadData();
        }
        public TableMng(int id)
        {
            this.iD = id;
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            loadData();
        }
        public async Task<IPagedList<TBL_STATUS>> getPagedList(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (DBCafe db = new DBCafe())
                {
                    return db.TBL_STATUS.OrderBy(x => x.iD_TBL).ToPagedList(pageNumber, pageSize);
                }
            });
        }
        private void selected(TBL_STATUS table)
        {
            tbl = table;
        }
        private void HandleEnter(object sender, KeyEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (e.Key == Key.Enter)
            {
                if (!txtSearch.Text.Equals(""))
                {
                    var getItem = from c in db.TBL_STATUS.ToList()
                                  where c.tbl_Name.Contains(txtSearch.Text.Trim())
                                  select c;
                    var listSearch = getItem.ToPagedList(pageNumber, pageSize);
                    drgStaff.ItemsSource = listSearch;
                    btnPrev.IsEnabled = listSearch.HasPreviousPage;
                    btnNext.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtSearch.Focus();
                }
            }
        }
        private void Reset()
        {
            loadData();
            txtSearch.Text = String.Empty;
            pageNumber = 1;
        }

        private async void loadData()
        {
            list = await getPagedList();
            btnPrev.IsEnabled = list.HasPreviousPage;
            btnNext.IsEnabled = list.HasNextPage;
            drgStaff.ItemsSource = list.ToList();
            lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
        }

        private async void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await getPagedList(--pageNumber);
                btnPrev.IsEnabled = list.HasPreviousPage;
                btnNext.IsEnabled = list.HasNextPage;
                drgStaff.ItemsSource = list.ToList();
                lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private async void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await getPagedList(++pageNumber);
                btnPrev.IsEnabled = list.HasPreviousPage;
                btnNext.IsEnabled = list.HasNextPage;
                drgStaff.ItemsSource = list.ToList();
                lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (!txtSearch.Text.Equals(""))
            {
                var getItem = from c in db.TBL_STATUS.ToList()
                              where c.tbl_Name.Contains(txtSearch.Text.Trim())
                              select c;
                var listSearch = getItem.ToPagedList(pageNumber, pageSize);
                drgStaff.ItemsSource = listSearch;
                btnPrev.IsEnabled = listSearch.HasPreviousPage;
                btnNext.IsEnabled = listSearch.HasNextPage;
                lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtSearch.Focus();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void addStaff_Click(object sender, RoutedEventArgs e)
        {
            AddTable add = new AddTable();
            add.ShowDialog();
            Reset();
            loadData();
        }

        private void btnEditStaff_Click(object sender, RoutedEventArgs e)
        {
            var tbl_Edit = db.TBL_STATUS.Find(tbl.iD_TBL);
            AddTable add = new AddTable(tbl_Edit);
            add.ShowDialog();
            loadData();
            Reset();
        }

        private void btnDeleteStaff_Click(object sender, RoutedEventArgs e)
        {
            var tbl_Del = db.TBL_STATUS.Find(tbl.iD_TBL);
            if (MessageBox.Show("Bạn có muốn xoá bàn: " + tbl_Del.tbl_Name + " không ?", "Cảnh báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                db.TBL_STATUS.Remove(tbl_Del);
                db.SaveChanges();
                Reset();
                loadData();
                MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void drgStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected((TBL_STATUS)drgStaff.SelectedItem);
        }
    }
}
