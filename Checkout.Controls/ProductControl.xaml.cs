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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Checkout.Resources;

namespace Checkout.Controls
{
    /// <summary>
    /// Interaction logic for ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        public ProductControl()
		{
			this.InitializeComponent();
            GetCultureContent();
		}

        private void GetCultureContent()
        {
            lblAisle.Content = ProductResources.lblAisle;
            lblBarcode.Content = ProductResources.lblBarcode;
            lblBrand.Content = ProductResources.lblBrand;
            lblDepartment.Content = ProductResources.lblDepartment;
            lblDisplayName.Content = ProductResources.lblDisplayName;
            lblDistributor.Content = ProductResources.lblDistributor;
            lblName.Content = ProductResources.lblName;
            lblPrice.Content = ProductResources.lblPrice;
            btnSubmit.Content = ProductResources.btnSubmit;
        }
    }
}
