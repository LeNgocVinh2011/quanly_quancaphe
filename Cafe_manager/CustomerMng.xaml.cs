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
    /// Interaction logic for CustomerMng.xaml
    /// </summary>
    public partial class CustomerMng : UserControl
    {
        int pageNumber = 1;
        IPagedList<ACCOUNT> list;
        DBCafe db = new DBCafe();
        ACCOUNT account;
        int iD;
        public CustomerMng()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            loadData();
        }

        public CustomerMng(int id)
        {
            this.iD = id;
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            loadData();
        }

        public async Task<IPagedList<ACCOUNT>> getPagedList(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (DBCafe db = new DBCafe())
                {
                    return db.ACCOUNTs.OrderBy(x => x.acc_Id).Where(x => x.Type == 0).ToPagedList(pageNumber, pageSize);
                }
            });
        }
        private void HandleEnter(object sender, KeyEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (e.Key == Key.Enter)
            {
                if (!txtSearch.Text.Equals(""))
                {
                    var getItem = from c in db.ACCOUNTs.ToList()
                                  where c.DisplayName.Contains(txtSearch.Text.Trim())
                                  select c;
                    var listSearch = getItem.Where(x => x.Type == 0).ToPagedList(pageNumber, pageSize);
                    drgStaff.ItemsSource = listSearch;
                    btnPrevCus.IsEnabled = listSearch.HasPreviousPage;
                    btnNexCus.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtSearch.Focus();
                }
            }
        }
        private async void loadData()
        {
            list = await getPagedList();
            btnPrevCus.IsEnabled = list.HasPreviousPage;
            btnNexCus.IsEnabled = list.HasNextPage;
            drgStaff.ItemsSource = list.ToList();
            lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
        }
        private void selected(ACCOUNT acc)
        {
            account = acc;
        }

        private void Reset()
        {
            loadData();
            txtSearch.Text = String.Empty;
            pageNumber = 1;
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (!txtSearch.Text.Equals(""))
            {
                var getItem = from c in db.ACCOUNTs.ToList()
                              where c.DisplayName.Contains(txtSearch.Text.Trim())
                              select c;
                var listSearch = getItem.Where(x => x.Type == 0).ToPagedList(pageNumber, pageSize);
                drgStaff.ItemsSource = listSearch;
                btnPrevCus.IsEnabled = listSearch.HasPreviousPage;
                btnNexCus.IsEnabled = listSearch.HasNextPage;
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
            AddCus addCus = new AddCus();
            addCus.ShowDialog();
            db.SaveChanges();
            Reset();
            loadData();
        }


        private void btnEditStaff_Click(object sender, RoutedEventArgs e)
        {
            var acc = db.ACCOUNTs.Find(account.acc_Id);
            AddCus add = new AddCus(acc);
            add.ShowDialog();
            db.SaveChanges();
            Reset();
            loadData();
        }

        private void btnDeleteStaff_Click(object sender, RoutedEventArgs e)
        {
            var accDel = db.ACCOUNTs.Find(account.acc_Id);
            if (MessageBox.Show("Bạn có muốn xoá tài khoản: " + accDel.UserName + " không ?", "Cảnh báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                db.ACCOUNTs.Remove(accDel);
                db.SaveChanges();
                Reset();
                loadData();
                MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private async void btnNexCus_Click(object sender, RoutedEventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await getPagedList(++pageNumber);
                btnPrevCus.IsEnabled = list.HasPreviousPage;
                btnNexCus.IsEnabled = list.HasNextPage;
                drgStaff.ItemsSource = list.ToList();
                lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private async void btnPrevCus_Click(object sender, RoutedEventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await getPagedList(--pageNumber);
                btnPrevCus.IsEnabled = list.HasPreviousPage;
                btnNexCus.IsEnabled = list.HasNextPage;
                drgStaff.ItemsSource = list.ToList();
                lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private void drgStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected((ACCOUNT)drgStaff.SelectedItem);
        }
    }
}
