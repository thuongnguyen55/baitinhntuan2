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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace baitwoky2
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

        private void BtnTinh_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(txtnhap.Text);
            double nhap = 0.0;
            if (n < 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    nhap += i * i;
                }
                MessageBox.Show("Kết quả: " + nhap);
            }
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
