using Cafe_manager.Models;
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
using System.Windows.Shapes;

namespace Cafe_manager
{
    /// <summary>
    /// Interaction logic for BillData.xaml
    /// </summary>
    public partial class BillData : Window
    {
        int Id;
        double countSum;
        DBCafe db = new DBCafe();
        public BillData()
        {
            InitializeComponent();
            loadBill();
        }

        public BillData(int id)
        {
            this.Id = id;
            InitializeComponent();
            loadBill();
        }

        private void loadBill()
        {
            var listData = db.BILLINFOes.Include(x => x.FRUID).Include(x => x.BILL).Include(x => x.BILL.TBL_STATUS).Where(x => x.BILL.status == 0 && x.BILL.acc_Id == Id).ToList();
            if (listData.Count > 0)
            {
                grbData.Visibility = Visibility.Visible;
                grbEmty.Visibility = Visibility.Hidden;
                btnPrintBill.IsEnabled = true;
                drgBill.ItemsSource = listData;
                drgBillPrint.ItemsSource = listData;
                lbTimeBill.Content = "Ngày xuất: " + DateTime.Now;
                var acc = db.ACCOUNTs.SingleOrDefault(x => x.acc_Id == Id);
                lbCustumer.Content = "KHÁCH HÀNG: " + acc.DisplayName;
                foreach (var item in listData)
                {
                    countSum += item.sum;
                }
                txtCount.Content = "Tồng tiền thanh toán: " + countSum;
                lbBillSum.Content = "Tổng tiền: " + countSum;
            }
            else
            {
                grbData.Visibility = Visibility.Hidden;
                grbEmty.Visibility = Visibility.Visible;
                var acc = db.ACCOUNTs.SingleOrDefault(x => x.acc_Id == Id);
                txtEmpty.Content = "Xin chào " + acc.DisplayName + ", bạn chưa có hoá đơn nào...";
                btnPrintBill.IsEnabled = false;
                btnCheckBill.IsEnabled = false;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var listData = db.BILLINFOes.Include(x => x.FRUID).Include(x => x.BILL).Include(x => x.BILL.TBL_STATUS).Where(x => x.BILL.status == 0 && x.BILL.acc_Id == Id).ToList();
            foreach (var item in listData)
            {
                item.BILL.status = 1;
                item.BILL.TBL_STATUS.status = "Trống";
                item.BILL.DateCheckOut = DateTime.Now;
                db.BILLINFOes.Remove(item);
                db.SaveChanges();
            }
            txtCount.Content = "Tồng tiền thanh toán: 0" ;
            loadBill();
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if(printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(billData, "invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
                btnCheckBill.IsEnabled = true;
                btnPrintBill.IsEnabled = false;
            }
        }
    }
}
