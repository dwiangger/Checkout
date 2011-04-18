using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Checkout.Resources;
using Checkout.Forms.Manager;

namespace Checkout
{
    /// <summary>
    /// Interaction logic for Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
            GetCultureContent();
        }

        private void GetCultureContent()
        {
            btnViewProducts.Content = ManagerResources.btnViewProducts;
            lblInfo.Content = ManagerResources.lblInfo;
        }

        private void btnViewProduct_Click(object sender, RoutedEventArgs e)
        {
            View_Products form = new View_Products();
            form.Show();
        }
    }
}
