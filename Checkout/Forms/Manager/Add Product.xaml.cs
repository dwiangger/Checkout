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

namespace Checkout.Forms.Manager
{
    /// <summary>
    /// Interaction logic for Add_Product.xaml
    /// </summary>
    public partial class Add_Product : Window
    {
        public Add_Product()
        {
            InitializeComponent();
            GetCultureContent();
        }

        private void GetCultureContent()
        {
            Title = Add_ProductResources.FormTitle;
            lblInfo.Content = Add_ProductResources.lblInfo;
        }
    }
}
