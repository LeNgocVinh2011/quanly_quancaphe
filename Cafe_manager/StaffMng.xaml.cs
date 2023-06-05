using Cafe_manager.Models;
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
using PagedList;

namespace Cafe_manager
{
    /// <summary>
    /// Interaction logic for StaffMng.xaml
    /// </summary>
    public partial class StaffMng : UserControl
    {
        int pageNumber = 1;
        IPagedList<ACCOUNT> list;
        ACCOUNT account;
        int iD;
        DBCafe db = new DBCafe();
        public StaffMng()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            createData();
            loadData();
        }
        public async Task<IPagedList<ACCOUNT>> getPagedList(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() => 
            {
                using(DBCafe db = new DBCafe())
                {
                    return db.ACCOUNTs.OrderBy(x => x.acc_Id).Where(x => x.Type != 0).ToPagedList(pageNumber, pageSize);
                }
            });
        }
        
        private void Reset()
        {
            loadData();
            txtSearch.Text = String.Empty;
            cbxRoleAdmin.SelectedIndex = -1;
            pageNumber = 1;
        }
        public StaffMng(int id)
        {
            this.iD = id;
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            createData();
            loadData();
        }

        private void HandleEnter(object sender, KeyEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (e.Key == Key.Enter)
            {
                if (!txtSearch.Text.Equals(""))
                {
                    if (cbxRoleAdmin.SelectedIndex == -1)
                    {
                        var getItem = from c in db.ACCOUNTs.ToList()
                                      where c.DisplayName.Contains(txtSearch.Text)
                                      select c;
                        var listSearch = getItem.Where(x => x.Type != 0).ToPagedList(pageNumber, pageSize);
                        drgStaff.ItemsSource = listSearch;
                        btnPrev.IsEnabled = listSearch.HasPreviousPage;
                        btnNext.IsEnabled = listSearch.HasNextPage;
                        lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                    }
                    else
                    {
                        if (cbxRoleAdmin.SelectedIndex == 0)
                        {
                            drgStaff.ItemsSource = db.ACCOUNTs.Where(x => x.DisplayName == txtSearch.Text && x.Type != 0).ToList();
                            var getItem = from c in db.ACCOUNTs.ToList()
                                          where c.DisplayName.Contains(txtSearch.Text)
                                          select c;
                            var listSearch = getItem.Where(x => x.Type != 0 && x.Type == 1).ToPagedList(pageNumber, pageSize);
                            drgStaff.ItemsSource = listSearch;
                            btnPrev.IsEnabled = listSearch.HasPreviousPage;
                            btnNext.IsEnabled = listSearch.HasNextPage;
                            lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                        }
                        else
                        {
                            var getItem = from c in db.ACCOUNTs.ToList()
                                          where c.DisplayName.Contains(txtSearch.Text)
                                          select c;
                            var listSearch = getItem.Where(x => x.Type != 0 && x.Type == 2).ToPagedList(pageNumber, pageSize);
                            drgStaff.ItemsSource = listSearch;
                            btnPrev.IsEnabled = listSearch.HasPreviousPage;
                            btnNext.IsEnabled = listSearch.HasNextPage;
                            lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                        }
                    }
                }
                else if (cbxRoleAdmin.SelectedIndex != -1)
                {

                    if (cbxRoleAdmin.SelectedIndex == 0)
                    {
                        var getItem = from c in db.ACCOUNTs.ToList()
                                      where c.Type == 1
                                      select c;
                        var listSearch = getItem.ToPagedList(pageNumber, pageSize);
                        drgStaff.ItemsSource = listSearch;
                        btnPrev.IsEnabled = listSearch.HasPreviousPage;
                        btnNext.IsEnabled = listSearch.HasNextPage;
                        lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                    }
                    else
                    {
                        var getItem = from c in db.ACCOUNTs.ToList()
                                      where c.Type == 2
                                      select c;
                        var listSearch = getItem.ToPagedList(pageNumber, pageSize);
                        drgStaff.ItemsSource = listSearch;
                        btnPrev.IsEnabled = listSearch.HasPreviousPage;
                        btnNext.IsEnabled = listSearch.HasNextPage;
                        lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
                    txtSearch.Focus();
                }
            }
        }

        private void selected(ACCOUNT acc)
        {
            account = acc;
        }
        private async void loadData()
        {
            list = await getPagedList();
            btnPrev.IsEnabled = list.HasPreviousPage;
            btnNext.IsEnabled = list.HasNextPage;
            drgStaff.ItemsSource = list.ToList();
            lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, list.PageCount);
        }

        private void createData()
        {
            cbxRoleAdmin.Items.Add("Quản trị viên");
            cbxRoleAdmin.Items.Add("Nhân viên");
        }

        private void addStaff_Click(object sender, RoutedEventArgs e)
        {
            AddStaff add = new AddStaff();
            add.ShowDialog();
            Reset();
            loadData();
        }

        private void drgStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected((ACCOUNT)drgStaff.SelectedItem);
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

        private void btnEditStaff_Click(object sender, RoutedEventArgs e)
        {
            var acc = db.ACCOUNTs.Find(account.acc_Id);
            AddStaff add = new AddStaff(acc);
            add.ShowDialog();
            loadData();
            Reset();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int pageNumber = 1;
            int pageSize = 5;
            if (!txtSearch.Text.Equals(""))
            {
                if (cbxRoleAdmin.SelectedIndex == -1)
                {
                    var getItem = from c in db.ACCOUNTs.ToList()
                                  where c.DisplayName.Contains(txtSearch.Text)
                                  select c;
                    var listSearch = getItem.Where(x => x.Type != 0).ToPagedList(pageNumber, pageSize);
                    drgStaff.ItemsSource = listSearch;
                    btnPrev.IsEnabled = listSearch.HasPreviousPage;
                    btnNext.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                }
                else
                {
                    if (cbxRoleAdmin.SelectedIndex == 0)
                    {
                        drgStaff.ItemsSource = db.ACCOUNTs.Where(x => x.DisplayName == txtSearch.Text && x.Type != 0).ToList();
                        var getItem = from c in db.ACCOUNTs.ToList()
                                      where c.DisplayName.Contains(txtSearch.Text)
                                      select c;
                        var listSearch = getItem.Where(x => x.Type != 0 && x.Type == 1).ToPagedList(pageNumber, pageSize);
                        drgStaff.ItemsSource = listSearch;
                        btnPrev.IsEnabled = listSearch.HasPreviousPage;
                        btnNext.IsEnabled = listSearch.HasNextPage;
                        lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                    }
                    else
                    {
                        var getItem = from c in db.ACCOUNTs.ToList()
                                      where c.DisplayName.Contains(txtSearch.Text)
                                      select c;
                        var listSearch = getItem.Where(x => x.Type != 0 && x.Type == 2).ToPagedList(pageNumber, pageSize);
                        drgStaff.ItemsSource = listSearch;
                        btnPrev.IsEnabled = listSearch.HasPreviousPage;
                        btnNext.IsEnabled = listSearch.HasNextPage;
                        lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                    }
                }
            }
            else if (cbxRoleAdmin.SelectedIndex != -1)
            {

                if (cbxRoleAdmin.SelectedIndex == 0)
                {
                    var getItem = from c in db.ACCOUNTs.ToList()
                                  where c.Type == 1
                                  select c;
                    var listSearch = getItem.ToPagedList(pageNumber, pageSize);
                    drgStaff.ItemsSource = listSearch;
                    btnPrev.IsEnabled = listSearch.HasPreviousPage;
                    btnNext.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                }
                else
                {
                    var getItem = from c in db.ACCOUNTs.ToList()
                                  where c.Type == 2
                                  select c;
                    var listSearch = getItem.ToPagedList(pageNumber, pageSize);
                    drgStaff.ItemsSource = listSearch;
                    btnPrev.IsEnabled = listSearch.HasPreviousPage;
                    btnNext.IsEnabled = listSearch.HasNextPage;
                    lbPageNumber.Content = string.Format("Trang {0}/{1}", pageNumber, listSearch.PageCount);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
                txtSearch.Focus();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
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
    }
}
