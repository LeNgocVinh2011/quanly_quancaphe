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
using System.Windows.Shapes;

namespace Cafe_manager
{
    /// <summary>
    /// Interaction logic for MainUser.xaml
    /// </summary>
    public partial class MainUser : Window
    {
        DBCafe db = new DBCafe();
        string usernameU;
        int iD;
        public MainUser()
        {
            InitializeComponent();
        }

        public MainUser(int id,string name)
        {
            this.iD = id;
            this.usernameU = name;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            txtUserName.Text = usernameU;
            txtCafe.Text += ", xin chào: " + usernameU;
        }

        private void btnLogoutUser_Click(object sender, RoutedEventArgs e)
        {
            var acc = db.ACCOUNTs.SingleOrDefault(x => x.acc_Id == iD);
            MainLogin login = new MainLogin(acc.UserName, "");
            login.Show();
            this.Close();
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

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            TableData table = new TableData(iD);
            table.ShowDialog();
        }

        private void btnBill_Click(object sender, RoutedEventArgs e)
        {
            BillData bill = new BillData(iD);
            bill.ShowDialog();
        }
    }
}
