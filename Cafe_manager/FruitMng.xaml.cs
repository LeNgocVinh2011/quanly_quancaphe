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
    /// Interaction logic for FruitMng.xaml
    /// </summary>
    public partial class FruitMng : UserControl
    {
        int pageNumber = 1;
        IPagedList<FRUID_CATEGORIES> list;
        FRUID_CATEGORIES category;
        DBCafe db = new DBCafe();
        public FruitMng()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            loadData();
        }
        private void Reset()
        {
            loadData();
            txtSearch.Text = String.Empty;
            pageNumber = 1;
        }
        public async Task<IPagedList<FRUID_CATEGORIES>> getPagedList(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (DBCafe db = new DBCafe())
                {
                    return db.FRUID_CATEGORIES.OrderBy(x => x.cat_Id).ToPagedList(pageNumber, pageSize);
                }
            });
        }
        public async void loadData()
        {
            list = await getPagedList();
            btnPrev.IsEnabled = list.HasPreviousPage;
            btnNext.IsEnabled = list.HasNextPage;
            drgCat.ItemsSource = list.ToList();
            lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
        }

        private async void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await getPagedList(--pageNumber);
                btnPrev.IsEnabled = list.HasPreviousPage;
                btnNext.IsEnabled = list.HasNextPage;
                drgCat.ItemsSource = list.ToList();
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
                drgCat.ItemsSource = list.ToList();
                lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (!txtSearch.Text.Equals(""))
            {
                var getItem = from c in db.FRUID_CATEGORIES.ToList()
                              where c.Name.Contains(txtSearch.Text.Trim())
                              select c;
                var listSearch = getItem.ToPagedList(pageNumber, pageSize);
                drgCat.ItemsSource = listSearch;
                btnPrev.IsEnabled = listSearch.HasPreviousPage;
                btnNext.IsEnabled = listSearch.HasNextPage;
                lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
                txtSearch.Focus();
            }
        }
        private void HandleEnter(object sender, KeyEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (e.Key == Key.Enter)
            {
                if (!txtSearch.Text.Equals(""))
                {
                    var getItem = from c in db.FRUID_CATEGORIES.ToList()
                                  where c.Name.Contains(txtSearch.Text.Trim())
                                  select c;
                    var listSearch = getItem.ToPagedList(pageNumber, pageSize);
                    drgCat.ItemsSource = listSearch;
                    btnPrev.IsEnabled = listSearch.HasPreviousPage;
                    btnNext.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
                    txtSearch.Focus();
                }
            }
        }

        private void addCat_Click(object sender, RoutedEventArgs e)
        {
            AddCat add = new AddCat();
            add.ShowDialog();
            Reset();
            loadData();
        }
        private void selected(FRUID_CATEGORIES cat)
        {
            category = cat;
        }
        private void drgCat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected((FRUID_CATEGORIES)drgCat.SelectedItem);
        }

        private void btnDeleteCat_Click(object sender, RoutedEventArgs e)
        {
            var catDel = db.FRUID_CATEGORIES.Find(category.cat_Id);
            if (MessageBox.Show("Bạn có muốn xoá danh mục: " + catDel.Name + " không ?", "Cảnh báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                db.FRUID_CATEGORIES.Remove(catDel);
                db.SaveChanges();
                Reset();
                loadData();
                MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnEditCat_Click(object sender, RoutedEventArgs e)
        {

            var catEdit = db.FRUID_CATEGORIES.Find(category.cat_Id);
            AddCat add = new AddCat(catEdit);
            add.ShowDialog();
            loadData();
            Reset();
        }
    }
}
