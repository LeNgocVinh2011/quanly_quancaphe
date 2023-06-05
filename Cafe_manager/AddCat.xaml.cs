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
    /// Interaction logic for AddCat.xaml
    /// </summary>
    public partial class AddCat : Window
    {
        DBCafe db = new DBCafe();
        FRUID_CATEGORIES category;
        public AddCat()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }
        public AddCat(FRUID_CATEGORIES cat)
        {
            this.category = cat;
            InitializeComponent();
            getData();
            this.PreviewKeyDown += new KeyEventHandler(HandleEnter);
        }
        private void getData()
        {
            if (category != null)
            {
                lbName.Content = "SỬA THÔNG TIN DANH MỤC";
                btnCreate.Content = "Lưu thay đổi";
                editCatName.Text = category.Name;
                editImgPath.Text = category.imgPath;
                ImageSource imageSource = new BitmapImage(new Uri(editImgPath.Text));
                imgPath.Source = imageSource;
            }
        }
        private void HandleEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (category == null)
                {
                    if (editCatName.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập tên danh mục", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editCatName.Focus();
                    }
                    else if (editImgPath.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn chưa nhập link ảnh", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        editImgPath.Focus();
                    }
                    else
                    {
                        var cat = db.FRUID_CATEGORIES.SingleOrDefault(x => x.Name == editCatName.Text);
                        if (cat == null)
                        {
                            var catAdd = new FRUID_CATEGORIES();
                            catAdd.Name = editCatName.Text;
                            catAdd.imgPath = editImgPath.Text;
                            db.FRUID_CATEGORIES.Add(catAdd);
                            db.SaveChanges();
                            MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Danh mục đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                            editCatName.Focus();
                        }
                    }
                }
                else
                {
                    var existing = db.FRUID_CATEGORIES.Find(category.cat_Id);
                    existing.Name = editCatName.Text;
                    existing.imgPath = editImgPath.Text;
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
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

        private void btnGetLink_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*";
            openFileDialog1.DefaultExt = ".jpeg";
            editImgPath.Text = openFileDialog1.FileName;
            if(editImgPath != null)
            {
                ImageSource imageSource = new BitmapImage(new Uri(editImgPath.Text));
                imgPath.Source = imageSource;
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if(category == null)
            {
                if (editCatName.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập tên danh mục", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editCatName.Focus();
                }
                else if (editImgPath.Text.Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập link ảnh", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    editImgPath.Focus();
                }
                else
                {
                    var cat = db.FRUID_CATEGORIES.SingleOrDefault(x => x.Name == editCatName.Text);
                    if (cat == null)
                    {
                        var catAdd = new FRUID_CATEGORIES();
                        catAdd.Name = editCatName.Text;
                        catAdd.imgPath = editImgPath.Text;
                        db.FRUID_CATEGORIES.Add(catAdd);
                        db.SaveChanges();
                        MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Danh mục đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        editCatName.Focus();
                    }
                }
            }
            else
            {
                var existing = db.FRUID_CATEGORIES.Find(category.cat_Id);
                existing.Name = editCatName.Text;
                existing.imgPath = editImgPath.Text;
                db.SaveChanges();
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}
