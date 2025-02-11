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

namespace Bai3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> list = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            try
            {
                string Name = txtName.Text;
                string GioiTinh = radGioiTinhNam.IsChecked == true ? "Nam" : "Nữ";
                int Age = int.Parse(txtAge.Text);
                
                user.Name = Name;
                user.GioiTinh = GioiTinh;
                try
                {
                    user.Age = Age;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi nhập liệu",  MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập đúng định dạng số!", "Lỗi nhập liệu", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            list.Add(user);
            dtgInfo.ItemsSource = list.ToList();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                GioiTinh = radGioiTinhNam.IsChecked == true ? "Nam" : "Nữ"
            };
            In inthongtin = new In(user);
            inthongtin.Show();
        }
    }
}