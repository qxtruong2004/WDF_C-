using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string Name = cboName.SelectedItem.ToString();
                double Old = double.Parse(txtOld.Text);
                double New = double.Parse(txtNew.Text);
                // Tạo đối tượng hóa đơn
                HoaDon hd = new HoaDon();
                hd.Old = Old;
                try
                {
                    hd.New = New; // Nếu sai, sẽ ném lỗi
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButton.OK, MessageBoxImage.Error);
                    return; // Dừng chương trình để người dùng nhập lại
                }
                txbTotal_Pay.Text = hd.Total_Pay.ToString();
                txbSpend.Text = hd.Spend.ToString();
                txbSpendOver.Text = hd.SpendOver.ToString();
                txbSpendUnder.Text = hd.SpendUnder.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập đúng định dạng số!", "Lỗi nhập liệu", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            HoaDon hd = new HoaDon()
            {
                Name = cboName.SelectedItem.ToString(),
                Old = double.Parse(txtOld.Text),
                New = double.Parse(txtNew.Text)
            };

            // Hiển thị tổng tiền trong TextBox
            txbTotal_Pay.Text = hd.Total_Pay.ToString("N0") + " VND";

            // Tạo cửa sổ mới và truyền dữ liệu
            InHoaDon inHoaDon = new InHoaDon(hd);
            inHoaDon.Show();
        }
    }
}