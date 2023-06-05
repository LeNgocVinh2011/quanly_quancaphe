using Cafe_manager.Models;
using System;
using System.Linq;
using System.Windows.Controls;

namespace Cafe_manager
{
    /// <summary>
    /// Interaction logic for DataBroad.xaml
    /// </summary>
    public partial class DataBroad : UserControl
    {
        string date = DateTime.UtcNow.ToString("dd/MM/yyyy");
        DBCafe db = new DBCafe();
        public DataBroad()
        {
            InitializeComponent();
        }

        private void createData()
        {
            txtThongKe.Text += date;
        }
    }
}
