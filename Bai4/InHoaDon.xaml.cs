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

namespace Bai4
{
    /// <summary>
    /// Interaction logic for InHoaDon.xaml
    /// </summary>
    public partial class InHoaDon : Window
    {
        public InHoaDon(HoaDon hd)
        {
            InitializeComponent();
            // Hiển thị thông tin hóa đơn trên UI
            lblName.Text = $"Khách hàng: {hd.Name}";
            lblSpend.Text = $"Số kW đã dùng: {hd.Spend} kW";
            lblTotalPay.Text = $"Số tiền phải trả: {hd.Total_Pay:N0} VND";
        }
    }
}
