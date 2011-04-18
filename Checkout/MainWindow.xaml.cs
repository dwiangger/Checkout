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
using Checkout.Models;
using Checkout.Resources;

namespace Checkout
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

        private void GetCultureContent()
        {
            Title = MainWindowResources.FormTitle;
            lblInfo.Content = MainWindowResources.lblInfo;
            btnLaunchPOS.Content = MainWindowResources.btnLaunchPOS;
            btnManage.Content = MainWindowResources.btnManage;
            btnStatistics.Content = MainWindowResources.btnStatistics;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Load culture specific content
            GetCultureContent();
        }
        
        private void btnLaunchPOS_Click(object sender, RoutedEventArgs e)
        {
            //Initialize the PointofSale form.
            PointofSale form = new PointofSale();
            //Show the Point of Sale form.
            form.Show();
        }

        private void btnManage_Click(object sender, RoutedEventArgs e)
        {
            //Initialize the Manager form.
            Manager form = new Manager();
            //Show the Manager form.
            form.Show();
        }

        private void btnStatistics_Click(object sender, RoutedEventArgs e)
        {
            //Initialize the Statistics form.
            Statistics form = new Statistics();
            //Show the Statistics form.
            form.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
