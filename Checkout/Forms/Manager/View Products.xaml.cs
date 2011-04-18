using System.Windows;
using Checkout.ViewModels;

namespace Checkout.Forms.Manager
{
    /// <summary>
    /// Interaction logic for View_Products.xaml
    /// </summary>
    public partial class View_Products : Window
    {
        public View_Products()
        {
            InitializeComponent();
            DataContext = new ViewProductsViewModel();
        }

        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            Add_Product form = new Add_Product();
            form.ShowDialog();
        }
    }
}
