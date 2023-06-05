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
    /// Interaction logic for MainAdmin.xaml
    /// </summary>
    public partial class MainAdmin : Window
    {
        DBCafe db = new DBCafe();
        UserControl usc = null;
        string username;
        int iD;
        public MainAdmin()
        {
            InitializeComponent();
        }
        public MainAdmin(int id,string name)
        {
            this.username = name;
            this.iD = id;
            InitializeComponent();
            checkUser();
            ListViewMenu.SelectedIndex = 0;
            Init();
        }

        private void checkUser()
        {
            var acc = db.ACCOUNTs.Find(iD);
            if(acc.Type == 1)
            {
                ItemStaff.Visibility = Visibility.Visible;
            }
            else
            {
                ItemStaff.Visibility = Visibility.Collapsed;
            }
        }

        private void Init()
        {
            txtUserName.Text = username;
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Collapsed;
            btnCloseMenu.Visibility = Visibility.Visible;
        }
     

        private void btnCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Visible;
            btnCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            var acc = db.ACCOUNTs.SingleOrDefault(x => x.acc_Id == iD);
            MainLogin login = new MainLogin(acc.UserName, "");
            login.Show();
            this.Close();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new DataBroad();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemStaff":
                    usc = new StaffMng(iD);
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCus":
                    usc = new CustomerMng();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemTab":
                    usc = new TableMng();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCat":
                    usc = new FruitMng();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemPro":
                    usc = new ProductsMng();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
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
    }
}
