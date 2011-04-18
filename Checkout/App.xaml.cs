using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Checkout.Models;

namespace Checkout
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            //Launch Checkout in different languages
                //French
                    //SetCulture("fr-CA");
                //German
                    //SetCulture("de-DE");
        }
        
        private void SetCulture(string Culture)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Culture);
        }
    }
}
