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

namespace VoTruongPhuWPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void ManageCustomers_Click(object sender, RoutedEventArgs e)
        {
            
            var win = new CustomerViewWindow();
            win.ShowDialog();
        }

        private void ManageProducts_Click(object sender, RoutedEventArgs e)
        {
            var win = new ProductWindow();
            win.ShowDialog();
        }

        private void ManageOrders_Click(object sender, RoutedEventArgs e)
        {
            var win = new OrderWindow();
            win.ShowDialog();
        }

        private void ViewReports_Click(object sender, RoutedEventArgs e)
        {
            var win = new ReportWindow();
            win.ShowDialog();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            
            new Window1().Show();
            

            this.Close();  
        }
    }
}
    

