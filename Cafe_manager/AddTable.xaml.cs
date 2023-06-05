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
    /// Interaction logic for AddTable.xaml
    /// </summary>
    public partial class AddTable : Window
    {
        TBL_STATUS table;
        DBCafe db = new DBCafe();
        public AddTable()
        {
            InitializeComponent();
            getData();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }
        public AddTable(TBL_STATUS tbl)
        {
            this.table = tbl;
            InitializeComponent();
            getData();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }

        private void getData()
        {
            if (table != null)
            {
                lbName.Content = "SỬA THÔNG TIN BÀN ĂN";
                btnCreate.Content = "Lưu thay đổi";
                editTableName.Text = table.tbl_Name;
                editTableStatus.Text = table.status;
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
        private void HandleEnter(object sender, KeyEventArgs e)
        {
            if (table == null)
            {
                if (e.Key == Key.Enter)
                {
                    if (editTableName.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập tên bàn ăn", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editTableName.Focus();
                    }
                    else
                    {
                        var tbl = db.TBL_STATUS.SingleOrDefault(x => x.tbl_Name == editTableName.Text);
                        if (tbl == null)
                        {
                            var tbl_add = new TBL_STATUS();
                            tbl_add.tbl_Name = editTableName.Text;
                            tbl_add.status = editTableStatus.Text;
                            db.TBL_STATUS.Add(tbl_add);
                            db.SaveChanges();
                            MessageBox.Show("Thêm bàn ăn thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm bàn ăn do bàn ăn đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                            editTableName.Focus();
                        }
                    }
                }
            }
            else
            {
                if (e.Key == Key.Enter)
                {
                    var existing = db.TBL_STATUS.Find(table.iD_TBL);
                    existing.tbl_Name = editTableName.Text;
                    existing.status = editTableStatus.Text;
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
        }
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if(table == null)
            {
                if (editTableName.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập tên bàn ăn", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editTableName.Focus();
                }
                else
                {
                    var tbl = db.TBL_STATUS.SingleOrDefault(x => x.tbl_Name == editTableName.Text);
                    if (tbl == null)
                    {
                        var tbl_add = new TBL_STATUS();
                        tbl_add.tbl_Name = editTableName.Text;
                        tbl_add.status = editTableStatus.Text;
                        db.TBL_STATUS.Add(tbl_add);
                        db.SaveChanges();
                        MessageBox.Show("Thêm bàn ăn thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm bàn ăn do bàn ăn đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        editTableName.Focus();
                    }
                }
            }
            else
            {
                var existing = db.TBL_STATUS.Find(table.iD_TBL);
                existing.tbl_Name = editTableName.Text;
                existing.status = editTableStatus.Text;
                db.SaveChanges();
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}
