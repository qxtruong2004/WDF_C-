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

namespace Bai3
{
    /// <summary>
    /// Interaction logic for In.xaml
    /// </summary>
    public partial class In : Window
    {
        public In(User user)
        {
            InitializeComponent();
            lblName.Text = $"Họ và tên: {user.Name}";
            lblAge.Text = $"Tuổi: {user.Age} ";
            lblGioiTinh.Text = $"Giới tính: {user.GioiTinh} ";
        }
    }
}
