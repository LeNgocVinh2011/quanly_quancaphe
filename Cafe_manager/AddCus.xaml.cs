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
    /// Interaction logic for AddCus.xaml
    /// </summary>
    public partial class AddCus : Window
    {
        ACCOUNT accountEdit;
        DBCafe db = new DBCafe();
        public AddCus()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }

        private void HandleEnter(object sender, KeyEventArgs e)
        {
            if (accountEdit == null)
            {
                if (e.Key == Key.Enter)
                {
                    if (editUsernameAdd.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập tên tài khoản", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editUsernameAdd.Focus();
                    }
                    else if (editDisplayNameAdd.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập tên người dùng", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editDisplayNameAdd.Focus();
                    }
                    else if (editPasswordAdd.Password.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editPasswordAdd.Focus();
                    }
                    else
                    {
                        var acc = db.ACCOUNTs.SingleOrDefault(x => x.UserName == editUsernameAdd.Text);
                        if (acc == null)
                        {
                            var account = new ACCOUNT();
                            MD5 mD5 = new MD5();
                            string pass = mD5.MD5Hash(editPasswordAdd.Password);
                            account = new ACCOUNT();
                            account.UserName = editUsernameAdd.Text;
                            account.DisplayName = editDisplayNameAdd.Text;
                            account.PassWord = pass;
                            account.Type = 0;
                            db.ACCOUNTs.Add(account);
                            db.SaveChanges();
                            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm tài khoản do tài khoản đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                            editUsernameAdd.Focus();
                        }
                    }
                }
            } 
            else
            {
                if (e.Key == Key.Enter)
                {
                    MD5 mD5 = new MD5();
                    var existing = db.ACCOUNTs.Find(accountEdit.acc_Id);
                    string newPass = mD5.MD5Hash(editPasswordAdd.Password);
                    existing.UserName = editUsernameAdd.Text;
                    existing.DisplayName = editDisplayNameAdd.Text;
                    existing.PassWord = newPass;
                    existing.Type = 0;
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
        }
        public AddCus(ACCOUNT acc)
        {
            this.accountEdit = acc;
            InitializeComponent();
            getData();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }

        private void getData()
        {
            if (accountEdit != null)
            {
                lbName.Content = "SỬA THÔNG TIN NGƯỜI DÙNG";
                btnCreate.Content = "Lưu thay đổi";
                editUsernameAdd.Text = accountEdit.UserName;
                editDisplayNameAdd.Text = accountEdit.DisplayName;
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if(accountEdit == null)
            {
                if (editUsernameAdd.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editUsernameAdd.Focus();
                }
                else if (editDisplayNameAdd.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập tên người dùng", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editDisplayNameAdd.Focus();
                }
                else if (editPasswordAdd.Password.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editPasswordAdd.Focus();
                }
                else
                {
                    var acc = db.ACCOUNTs.SingleOrDefault(x => x.UserName == editUsernameAdd.Text);
                    if (acc == null)
                    {
                        var account = new ACCOUNT();
                        MD5 mD5 = new MD5();
                        string pass = mD5.MD5Hash(editPasswordAdd.Password);
                        account = new ACCOUNT();
                        account.UserName = editUsernameAdd.Text;
                        account.DisplayName = editDisplayNameAdd.Text;
                        account.PassWord = pass;
                        account.Type = 0;
                        db.ACCOUNTs.Add(account);
                        db.SaveChanges();
                        MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm tài khoản do tài khoản đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        editUsernameAdd.Focus();
                    }
                }
            }
            else
            {
                MD5 mD5 = new MD5();
                var existing = db.ACCOUNTs.Find(accountEdit.acc_Id);
                string newPass = mD5.MD5Hash(editPasswordAdd.Password);
                existing.UserName = editUsernameAdd.Text;
                existing.DisplayName = editDisplayNameAdd.Text;
                existing.PassWord = newPass;
                existing.Type = 0;
                db.SaveChanges();
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
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

        private void ShowPass_Checked(object sender, RoutedEventArgs e)
        {
            editPasswordAdd.Visibility = Visibility.Hidden;
            editPasswordView.Visibility = Visibility.Visible;
            editPasswordView.Text = editPasswordAdd.Password;
        }

        private void ShowPass_Unchecked(object sender, RoutedEventArgs e)
        {
            editPasswordAdd.Visibility = Visibility.Visible;
            editPasswordView.Visibility = Visibility.Hidden;
        }
    }
}
