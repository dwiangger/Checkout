using System.Collections.Generic;
using Checkout.Models;

namespace Checkout.ViewModels
{
    public class ViewProductsViewModel : ViewModelBase
    {
        public ViewProductsViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            _db = new StoreRepository();
        }

        private IStoreRepository _db;

        public IEnumerable<Product> Products
        {
            get { return _db.FindProduct(); }
        }

        #region Localization Properties
        public string FormTitle { get { return Resources.ViewProductsResources.FormTitle; } }
        public string lblSortBy { get { return Resources.ViewProductsResources.lblSortBy; } }
        public string lblPrice { get { return Resources.ViewProductsResources.lblPrice; } }
        public string lblBrand { get { return Resources.ViewProductsResources.lblBrand; } }
        public string lblAisle { get { return Resources.ViewProductsResources.lblAisle; } }
        public string lblDepartment { get { return Resources.ViewProductsResources.lblDepartment; } }
        public string lblBarcode { get { return Resources.ViewProductsResources.lblBarcode; } }
        public string lblDistributor { get { return Resources.ViewProductsResources.lblDistributor; } }
        public string lblDisplayName { get { return Resources.ViewProductsResources.lblDisplayName; } }
        public string btnAddProduct { get { return Resources.ViewProductsResources.btnAddProduct; } }
        public string btnSortByName { get { return Resources.ViewProductsResources.btnSortByName; } }
        public string btnSortByPrice { get { return Resources.ViewProductsResources.btnSortByPrice; } }
        public string btnSortByDepartment { get { return Resources.ViewProductsResources.btnSortByDepartment; } }
        public string btnSortByAisle { get { return Resources.ViewProductsResources.btnSortByAisle; } }
        public string btnSortByBrand { get { return Resources.ViewProductsResources.btnSortByBrand; } }
        public string btnSortByDistributor { get { return Resources.ViewProductsResources.btnSortByDistributor; } }
        public string gvcName { get { return Resources.ViewProductsResources.gvcName; } }
        public string gvcAisle { get { return Resources.ViewProductsResources.gvcAisle; } }
        #endregion
    }
}
