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
    /// Interaction logic for MainRegister.xaml
    /// </summary>
    public partial class MainRegister : Window
    {
        ACCOUNT account;
        DBCafe db = new DBCafe();
        public MainRegister()
        {
            InitializeComponent();
            editUsernameRes.Focus();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }

        private void HandleEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (editUsernameRes.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editUsernameRes.Focus();
                }
                else if (editDisplayNameRes.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập tên hiển thị", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editDisplayNameRes.Focus();
                }
                else if (editPasswordRes.Password.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editPasswordRes.Focus();
                }
                else if (editConfirmPass.Password.Equals(""))
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editConfirmPass.Focus();
                }

                else
                {
                    var acc = db.ACCOUNTs.SingleOrDefault(x => x.UserName == editUsernameRes.Text);
                    if (acc == null)
                    {
                        MD5 mD5 = new MD5();
                        string pass = mD5.MD5Hash(editPasswordRes.Password);
                        account = new ACCOUNT();
                        account.UserName = editUsernameRes.Text;
                        account.DisplayName = editDisplayNameRes.Text;
                        account.PassWord = pass;
                        account.Type = 0;
                        db.ACCOUNTs.Add(account);
                        db.SaveChanges();
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainLogin login = new MainLogin(editUsernameRes.Text, editPasswordRes.Password);
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể đăng ký do tài khoản đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        editUsernameRes.Focus();
                    }
                }
            }
        }
        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainLogin login = new MainLogin();
            login.Show();
            this.Close();
        }

        private void btnLogUp_Click(object sender, RoutedEventArgs e)
        {
            if (editUsernameRes.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                editUsernameRes.Focus();
            }
            else if (editDisplayNameRes.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên hiển thị", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                editDisplayNameRes.Focus();
            }
            else if (editPasswordRes.Password.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                editPasswordRes.Focus();
            }
            else if (editConfirmPass.Password.Equals(""))
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                editConfirmPass.Focus();
            }
            else
            {
                var acc = db.ACCOUNTs.SingleOrDefault(x => x.UserName == editUsernameRes.Text);
                if (acc == null)
                {
                    MD5 mD5 = new MD5();
                    string pass = mD5.MD5Hash(editPasswordRes.Password);
                    account = new ACCOUNT();
                    account.UserName = editUsernameRes.Text;
                    account.DisplayName = editDisplayNameRes.Text;
                    account.PassWord = pass;
                    account.Type = 0;
                    db.ACCOUNTs.Add(account);
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainLogin login = new MainLogin(editUsernameRes.Text, editPasswordRes.Password);
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể đăng ký do tài khoản đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    editUsernameRes.Focus();
                }
            }
        }

        private void editConfirmPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (editConfirmPass.Password != editPasswordRes.Password)
            {
                lbError.Content = "Confirm password is not equals password";
                lbError.Foreground = Brushes.Red;
            }
            else
            {
                lbError.Content = "";
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
