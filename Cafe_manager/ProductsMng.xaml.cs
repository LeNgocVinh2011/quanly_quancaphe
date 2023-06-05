using Cafe_manager.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for ProductsMng.xaml
    /// </summary>
    public partial class ProductsMng : UserControl
    {
        int pageNumber = 1;
        IPagedList<FRUID> list;
        DBCafe db = new DBCafe();
        FRUID_CATEGORIES itemSelected;
        FRUID fruidselect;
        public ProductsMng()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            loadData();
        }

        public async Task<IPagedList<FRUID>> getPagedList(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (DBCafe db = new DBCafe())
                {
                    return db.FRUIDs.OrderBy(x => x.f_Id).Where(x => x.isDeleted == 0).Include(x => x.FRUID_CATEGORIES).ToPagedList(pageNumber, pageSize);
                }
            });
        }

        private void Reset()
        {
            loadData();
            txtSearch.Text = String.Empty;
            cbxCategories.SelectedIndex = -1;
            pageNumber = 1;
        }
        private async void loadData()
        {

            list = await getPagedList();
            btnPrev.IsEnabled = list.HasPreviousPage;
            btnNext.IsEnabled = list.HasNextPage;
            drgProducts.ItemsSource = list.ToList();
            lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
            cbxCategories.ItemsSource = db.FRUID_CATEGORIES.ToList();
        }

        private async void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await getPagedList(--pageNumber);
                btnPrev.IsEnabled = list.HasPreviousPage;
                btnNext.IsEnabled = list.HasNextPage;
                drgProducts.ItemsSource = list.ToList();
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
                drgProducts.ItemsSource = list.ToList();
                lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (cbxCategories.SelectedIndex == -1)
            {
                if (txtSearch.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu tìm kiếm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtSearch.Focus();
                }
                else
                {
                    var getItem = from c in db.FRUIDs.ToList()
                                  where c.Name.Contains(txtSearch.Text.Trim())
                                  select c;
                    var listSearch = getItem.Where(x => x.isDeleted == 0).ToPagedList(pageNumber, pageSize);
                    drgProducts.ItemsSource = listSearch;
                    btnPrev.IsEnabled = listSearch.HasPreviousPage;
                    btnNext.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                }
            }
            else
            {
                if (txtSearch.Text.Equals(""))
                {
                    var getItem = from c in db.FRUIDs.ToList()
                                  where c.FRUID_CATEGORIES.Name.Contains(itemSelected.Name.ToString().Trim())
                                  select c;
                    var listSearch = getItem.Where(x => x.isDeleted == 0).ToPagedList(pageNumber, pageSize);
                    drgProducts.ItemsSource = listSearch;
                    btnPrev.IsEnabled = listSearch.HasPreviousPage;
                    btnNext.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);

                }
                else
                {
                    var getItem = from c in db.FRUIDs.ToList()
                                  where c.Name.Contains(txtSearch.Text.Trim())
                                  select c;
                    var listSearch = getItem.Where(x => x.FRUID_CATEGORIES.Name == itemSelected.Name.ToString() && x.isDeleted == 0).ToPagedList(pageNumber, pageSize);
                    drgProducts.ItemsSource = listSearch;
                    btnPrev.IsEnabled = listSearch.HasPreviousPage;
                    btnNext.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                }
            }
        }

        private void HandleEnter(object sender, KeyEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (e.Key == Key.Enter)
            {
                if (cbxCategories.SelectedIndex == -1)
                {
                    if (txtSearch.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập dữ liệu tìm kiếm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        txtSearch.Focus();
                    }
                    else
                    {
                        var getItem = from c in db.FRUIDs.ToList()
                                      where c.Name.Contains(txtSearch.Text.Trim())
                                      select c;
                        var listSearch = getItem.Where(x => x.isDeleted == 0).ToPagedList(pageNumber, pageSize);
                        drgProducts.ItemsSource = listSearch;
                        btnPrev.IsEnabled = listSearch.HasPreviousPage;
                        btnNext.IsEnabled = listSearch.HasNextPage;
                        lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                    }
                }
                else
                {
                    if (txtSearch.Text.Equals(""))
                    {
                        var getItem = from c in db.FRUIDs.ToList()
                                      where c.FRUID_CATEGORIES.Name.Contains(itemSelected.Name.ToString().Trim())
                                      select c;
                        var listSearch = getItem.Where(x => x.isDeleted == 0).ToPagedList(pageNumber, pageSize);
                        drgProducts.ItemsSource = listSearch;
                        btnPrev.IsEnabled = listSearch.HasPreviousPage;
                        btnNext.IsEnabled = listSearch.HasNextPage;
                        lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);

                    }
                    else
                    {
                        var getItem = from c in db.FRUIDs.ToList()
                                      where c.Name.Contains(txtSearch.Text.Trim())
                                      select c;
                        var listSearch = getItem.Where(x => x.FRUID_CATEGORIES.Name == itemSelected.Name.ToString() && x.isDeleted == 0).ToPagedList(pageNumber, pageSize);
                        drgProducts.ItemsSource = listSearch;
                        btnPrev.IsEnabled = listSearch.HasPreviousPage;
                        btnNext.IsEnabled = listSearch.HasNextPage;
                        lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                    }
                }
            }
        }

        private void cbxCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            itemSelected = cbxCategories.SelectedItem as FRUID_CATEGORIES;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            var fruidDeleted = db.FRUIDs.Find(fruidselect.f_Id);
            if (MessageBox.Show("Bạn có muốn xoá sản phẩm: " + fruidDeleted.Name + " không ?", "Cảnh báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                fruidDeleted.isDeleted = 1;
                db.SaveChanges();
                Reset();
                loadData();
                MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void selected(FRUID fruid)
        {
            fruidselect = fruid;
        }
        private void drgProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected((FRUID)drgProducts.SelectedItem);
        }

        private void addProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProducts add = new AddProducts();
            add.ShowDialog();
            Reset();
            loadData();
        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            var proEdit = db.FRUIDs.Find(fruidselect.f_Id);
            AddProducts add = new AddProducts(proEdit);
            add.ShowDialog();
            loadData();
            Reset();
        }
    }
}
