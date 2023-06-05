using Cafe_manager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cafe_manager
{
    /// <summary>
    /// Interaction logic for Table.xaml
    /// </summary>
    public partial class TableData : Window
    {
        DBCafe db = new DBCafe();
        TBL_STATUS tblSelected;
        FRUID_CATEGORIES catSelected;
        FRUID fruidSelected;
        int Id;
        double price = 0;
        public TableData()
        {
            InitializeComponent();
            loadDataTbl();
            loadData();
        }

        public TableData(int cCOUNT)
        {
            this.Id = cCOUNT;
            InitializeComponent();
            loadDataTbl();
            loadData();
            loadBill();

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void loadData()
        {
            cbxCat.ItemsSource = db.FRUID_CATEGORIES.ToList();
        }
        private void loadBill()
        {
            drgBill.ItemsSource = db.BILLINFOes.Include(x => x.FRUID).Include(x => x.BILL).Where(x => x.BILL.status == 0 && x.BILL.acc_Id == Id).ToList();
        }
        private void loadDataTbl()
        {
            lstBox.ItemsSource = db.TBL_STATUS.ToList();
            if (lstBox.SelectedIndex == -1)
            {
                stContent.Visibility = Visibility.Hidden;
            }
        }
        private void Reset()
        {
            cbxCat.SelectedIndex = -1;
            cbxProducts.SelectedIndex = -1;
            cbxProducts.IsEnabled = false;
            txtCount.Text = "";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMiniSize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListBox)sender;
            tblSelected = (TBL_STATUS)item.SelectedItem;
            lbTable.Content = "Chọn bàn số: " + tblSelected.tbl_Name;
            if(lstBox.SelectedIndex != -1)
            {
                stContent.Visibility = Visibility.Visible;
            }
            if (tblSelected.status == "Có người")
            {
                btnAddFruid.IsEnabled = false;
                setTable.IsEnabled = false;
            }
            else
            {
                btnAddFruid.IsEnabled = true;
                setTable.IsEnabled = true;
            }
        }

        private void setTable_Click(object sender, RoutedEventArgs e)
        {
            tblSelected.status = "Có người";
            db.SaveChanges();
            loadDataTbl();
            MessageBox.Show("Đặt bàn thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            var acc = db.ACCOUNTs.SingleOrDefault(x => x.acc_Id == Id);
            cancelTable.Visibility = Visibility.Visible;
        }

        private void cbxCat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            catSelected = cbxCat.SelectedItem as FRUID_CATEGORIES;
            if (cbxCat.SelectedIndex != -1)
            {
                cbxProducts.ItemsSource = db.FRUIDs.Where(x => x.FRUID_CATEGORIES.Name == catSelected.Name.ToString()).ToList();
                cbxProducts.IsEnabled = true;
            }
            else
            {
                cbxProducts.IsEnabled = false;
            }
        }

        private void btnAddFruid_Click(object sender, RoutedEventArgs e)
        {
            if(cbxCat.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn món", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if(cbxProducts.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn món", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    if (txtCount.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        txtCount.Focus();
                    }
                    else
                    {
                        var billAdd = new BILL();
                        billAdd.DateCheckIn = DateTime.Now;
                        billAdd.DateCheckOut = null;
                        billAdd.tbl_Id = tblSelected.iD_TBL;
                        billAdd.status = 0;
                        billAdd.acc_Id = Id;
                        db.BILLs.Add(billAdd);
                        var checkData = db.BILLINFOes.SingleOrDefault(x => x.f_Id == fruidSelected.f_Id);
                        if(checkData != null)
                        {
                            checkData.count += Convert.ToInt32(txtCount.Text);
                            checkData.sum = Convert.ToInt32(checkData.count * price);
                        }
                        else
                        {
                            var billInforAdd = new BILLINFO();
                            billInforAdd.b_Id = billAdd.b_Id;
                            billInforAdd.count = Convert.ToInt32(txtCount.Text);
                            billInforAdd.f_Id = fruidSelected.f_Id;
                            billInforAdd.sum = Convert.ToInt32(Convert.ToInt32(txtCount.Text) * price);
                            db.BILLINFOes.Add(billInforAdd);
                        }
                        db.SaveChanges();
                        loadBill();
                        Reset();
                        MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                } 
            }
        }

        private void cbxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fruidSelected = cbxProducts.SelectedItem as FRUID;
            if(fruidSelected != null)
            {
                price = fruidSelected.Price;
            }
        }

        private void cancelTable_Click(object sender, RoutedEventArgs e)
        {
            var listData = db.BILLINFOes.Include(x => x.FRUID).Include(x => x.BILL).Where(x => x.BILL.status == 0 && x.BILL.acc_Id == Id).ToList();
            foreach(var item in listData)
            {
                item.BILL.status = 1;
                item.BILL.TBL_STATUS.status = "Trống";
                item.BILL.DateCheckOut = DateTime.Now;
                db.BILLINFOes.Remove(item);
                db.SaveChanges();
            }
            cancelTable.Visibility = Visibility.Hidden;
            loadDataTbl();
            stContent.Visibility = Visibility.Hidden;
        }
    }
}
