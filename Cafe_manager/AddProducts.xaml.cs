using Cafe_manager.Models;
using Microsoft.Win32;
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
    /// Interaction logic for AddProducts.xaml
    /// </summary>
    public partial class AddProducts : Window
    {
        DBCafe db = new DBCafe();
        FRUID proReceive;
        public AddProducts()
        {
            InitializeComponent();
            loadData();
        }

        public AddProducts(FRUID pro)
        {
            this.proReceive = pro;
            InitializeComponent();
            loadData();
            getData();
            //this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }

        private void getData()
        {
            if (proReceive != null)
            {
                lbName.Content = "SỬA THÔNG TIN SẢN PHẨM";
                btnCreate.Content = "Lưu thay đổi";
                editCatName.Text = proReceive.Name;
                if(proReceive.cat_Id == 1)
                {
                    cbxCategories.SelectedIndex = 0;
                }
                else if(proReceive.cat_Id == 2)
                {
                    cbxCategories.SelectedIndex = 1;
                }
                editImgPath.Text = proReceive.imgPath;
                editPrice.Text = proReceive.Price.ToString();
                ImageSource imageSource = new BitmapImage(new Uri(editImgPath.Text));
                imgPath.Source = imageSource;
            }
        }
        private void loadData()
        {
            cbxCategories.ItemsSource = db.FRUID_CATEGORIES.ToList();
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

        private void btnGetLink_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*";
            openFileDialog1.DefaultExt = ".jpeg";
            editImgPath.Text = openFileDialog1.FileName;
            if (editImgPath != null)
            {
                ImageSource imageSource = new BitmapImage(new Uri(editImgPath.Text));
                imgPath.Source = imageSource;
            }
        }
        private void HandleEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (proReceive == null)
                {
                    if (editCatName.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editCatName.Focus();
                    }
                    else if (cbxCategories.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn danh mục sản phẩm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else if (editPrice.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập link ảnh", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editPrice.Focus();
                    }
                    else if (editImgPath.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập link ảnh", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editImgPath.Focus();
                    }
                    else
                    {
                        var cat = db.FRUIDs.SingleOrDefault(x => x.Name == editCatName.Text);
                        if (cat == null)
                        {
                            var proAdd = new FRUID();
                            proAdd.Name = editCatName.Text;
                            proAdd.Price = Convert.ToInt32(editPrice.Text);
                            if (cbxCategories.SelectedIndex == 0)
                            {
                                proAdd.cat_Id = 1;
                            }
                            else if (cbxCategories.SelectedIndex == 1)
                            {
                                proAdd.cat_Id = 2;
                            }
                            proAdd.imgPath = editImgPath.Text;
                            proAdd.isDeleted = 0;
                            db.FRUIDs.Add(proAdd);
                            db.SaveChanges();
                            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                            editCatName.Focus();
                        }
                    }
                }
                else
                {
                    var existing = db.FRUIDs.Find(proReceive.f_Id);
                    existing.Name = editCatName.Text;
                    if (cbxCategories.SelectedIndex == 0)
                    {
                        existing.cat_Id = 1;
                    }
                    else if (cbxCategories.SelectedIndex == 1)
                    {
                        existing.cat_Id = 2;
                    }
                    existing.imgPath = editImgPath.Text;
                    existing.Price = Convert.ToInt32(editPrice.Text.Trim());
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
        }
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if(proReceive == null)
            {
                if (editCatName.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editCatName.Focus();
                }
                else if (cbxCategories.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn danh mục sản phẩm", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (editPrice.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập link ảnh", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editPrice.Focus();
                }
                else if (editImgPath.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập link ảnh", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editImgPath.Focus();
                }
                else
                {
                    var cat = db.FRUIDs.SingleOrDefault(x => x.Name == editCatName.Text);
                    if (cat == null)
                    {
                        var proAdd = new FRUID();
                        proAdd.Name = editCatName.Text;
                        proAdd.Price = Convert.ToInt32(editPrice.Text);
                        if (cbxCategories.SelectedIndex == 0)
                        {
                            proAdd.cat_Id = 1;
                        }
                        else if (cbxCategories.SelectedIndex == 1)
                        {
                            proAdd.cat_Id = 2;
                        }
                        proAdd.imgPath = editImgPath.Text;
                        proAdd.isDeleted = 0;
                        db.FRUIDs.Add(proAdd);
                        db.SaveChanges();
                        MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        editCatName.Focus();
                    }
                }
            }
            else
            {
                var existing = db.FRUIDs.Find(proReceive.f_Id);
                existing.Name = editCatName.Text;
                if (cbxCategories.SelectedIndex == 0)
                {
                    existing.cat_Id = 1;
                }
                else if (cbxCategories.SelectedIndex == 1)
                {
                    existing.cat_Id = 2;
                }
                existing.imgPath = editImgPath.Text;
                existing.Price = Convert.ToInt32(editPrice.Text.Trim());
                db.SaveChanges();
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}
