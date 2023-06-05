using Cafe_manager.Help;
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
    /// Interaction logic for MainLogin.xaml
    /// </summary>
    public partial class MainLogin : Window
    {
        DBCafe db = new DBCafe();
        string data = null;
        string usename, password;
        public MainLogin()
        {
            InitializeComponent();
            editUsername.Focus();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }
        public MainLogin(string user, string pass)
        {
            this.usename = user;
            this.password = pass;
            InitializeComponent();
            editUsername.Focus();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            Init();
        }

        private void Init()
        {
            editUsername.Text = usename;
            editPassword.Password = password;
        }


        private void HandleEnter(object sender, KeyEventArgs e)
        {
            string name = editUsername.Text.Trim();
            string pass = editPassword.Password.Trim();
            MD5 mD5 = new MD5();
            string passMd5 = mD5.MD5Hash(pass);
            var acc = db.ACCOUNTs.SingleOrDefault(x => x.UserName == name && x.PassWord == passMd5);
            if (e.Key == Key.Enter)
            {
                if (acc != null)
                {
                    if (acc.Type == 1)
                    {
                        data = acc.DisplayName;
                        MessageBox.Show("Xin chào admin: " + acc.DisplayName, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainAdmin main = new MainAdmin(acc.acc_Id,data);
                        main.Show();
                        this.Close();
                    }
                    else if (acc.Type == 0)
                    {
                        data = acc.DisplayName;
                        MessageBox.Show("Xin chào người dùng: " + acc.DisplayName, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainUser main = new MainUser(acc.acc_Id,data);
                        main.Show();
                        this.Close();
                    }
                    else
                    {
                        data = acc.DisplayName;
                        MessageBox.Show("Xin chào nhân viên: " + acc.DisplayName, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainAdmin main = new MainAdmin(acc.acc_Id,data);
                        main.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại thông tin đăng nhập", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void ShowPass_Checked(object sender, RoutedEventArgs e)
        {
            editPassword.Visibility = Visibility.Hidden;
            editPasswordView.Visibility = Visibility.Visible;
            editPasswordView.Text = editPassword.Password;
        }

        private void ShowPass_Unchecked(object sender, RoutedEventArgs e)
        {
            editPassword.Visibility = Visibility.Visible;
            editPasswordView.Visibility = Visibility.Hidden;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            MainRegister register = new MainRegister();
            register.Show();
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string name = editUsername.Text.Trim();
            string pass = editPassword.Password.Trim();
            MD5 mD5 = new MD5();
            string passMd5 = mD5.MD5Hash(pass);
            var acc = db.ACCOUNTs.SingleOrDefault(x => x.UserName == name && x.PassWord == passMd5);
            if (acc != null)
            {
                if (acc.Type == 1)
                {
                    data = acc.DisplayName;
                    MessageBox.Show("Xin chào admin: " + acc.DisplayName, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainAdmin main = new MainAdmin(acc.acc_Id,data);
                    main.Show();
                    this.Close();
                }
                else if(acc.Type == 0)
                {
                    data = acc.DisplayName;
                    MessageBox.Show("Xin chào người dùng: " + acc.DisplayName, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainUser main = new MainUser(acc.acc_Id,data);
                    main.Show();
                    this.Close();
                }
                else
                {
                    data = acc.DisplayName;
                    MessageBox.Show("Xin chào nhân viên: " + acc.DisplayName, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainAdmin main = new MainAdmin(acc.acc_Id, data);
                    main.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin đăng nhập", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
