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
    /// Interaction logic for AddStaff.xaml
    /// </summary>
    public partial class AddStaff : Window
    {
        ACCOUNT accountEdit;
        DBCafe db = new DBCafe();
        public AddStaff()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            createData();
        }
        
        public AddStaff(ACCOUNT acc)
        {
            this.accountEdit = acc;
            InitializeComponent();
            getData();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
            createData();
        }

        private void getData()
        {
            if(accountEdit != null)
            {
                lbName.Content = "SỬA THÔNG TIN NHÂN VIÊN";
                btnCreate.Content = "Lưu thay đổi";
                editUsernameAdd.Text = accountEdit.UserName;
                editDisplayNameAdd.Text = accountEdit.DisplayName;
                if(accountEdit.Type == 1)
                {
                    cbxRole.SelectedIndex = 0;
                }
                else if(accountEdit.Type == 2)
                {
                    cbxRole.SelectedIndex = 1;
                }
            }
        }

        private void HandleEnter(object sender, KeyEventArgs e)
        {
            if(accountEdit == null)
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
                    else if (cbxRole.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn quyền người dùng", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
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
                            if (cbxRole.SelectedIndex == 0)
                            {
                                account.Type = 1;
                            }
                            else
                            {
                                account.Type = 2;
                            }
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
                    if (cbxRole.SelectedIndex == 0)
                    {
                        existing.Type = 1;
                    }
                    else
                    {
                        existing.Type = 2;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
        }

        private void createData()
        {
            cbxRole.Items.Add("Quản trị viên");
            cbxRole.Items.Add("Nhân viên");
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
                else if (cbxRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn quyền người dùng", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
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
                        if (cbxRole.SelectedIndex == 0)
                        {
                            account.Type = 1;
                        }
                        else if(cbxRole.SelectedIndex == 1)
                        {
                            account.Type = 2;
                        }
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
                if (cbxRole.SelectedIndex == 0)
                {
                    existing.Type = 1;
                }
                else
                {
                    existing.Type = 2;
                }
                db.SaveChanges();
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
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
