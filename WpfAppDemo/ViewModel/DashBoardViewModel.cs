using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using WpfAppDemo_Library.Manager.AccountManager.Interface;
using WPFAppDemo_DTO.Account;
using WPFAppDemo_DTO.DashBoard;
using WPFAppDemo_Unity.UnityBase;
using WPFAppDemo_Library.Common;

namespace WpfAppDemo.ViewModel
{
    public class DashBoardViewModel : ViewModelBase
    {
        private IDashboardManager _objDashboardManager;

        private ObservableCollection<SalesDTO> _salesDataCollection;
        private ObservableCollection<SalesDTO> _yearCollection;
        private ObservableCollection<ProductDTO> _productCollection;
        private ObservableCollection<SalesDTO> _countryCollection;


        public DashBoardViewModel()
        {
            _objDashboardManager = CustomUnityContainer.Resolve<IDashboardManager>();
            GetSalesReport();
            GetProductList();
        }

        private void GetProductList()
        {
            ProductCollection = _objDashboardManager.GetProductList().ToObservableCollection();
        }

        public ObservableCollection<SalesDTO> SalesDataCollection
        {
            get { return _salesDataCollection; }
            set
            {
                _salesDataCollection = value;
                RaisePropertyChanged("SalesDataCollection");
            }
        }

        public ObservableCollection<SalesDTO> YearCollection
        {
            get { return _yearCollection; }
            set
            {
                _yearCollection = value;
                RaisePropertyChanged("YearCollection");
            }
        }

        public ObservableCollection<ProductDTO> ProductCollection
        {
            get { return _productCollection; }
            set
            {
                _productCollection = value;
                RaisePropertyChanged("ProductCollection");
            }
        }

        public ObservableCollection<SalesDTO> CountryCollection
        {
            get { return _countryCollection; }
            set { _countryCollection = value; }
        }
        private void GetSalesReport()
        {
            SalesDataCollection = _objDashboardManager.GetProductSales().ToObservableCollection();
            YearCollection = SalesDataCollection.GroupBy(x => x.Year).Select(m => m.First()).ToObservableCollection();
            CountryCollection = SalesDataCollection.GroupBy(x => x.Country).Select(m => m.First()).ToObservableCollection();
        }

        private string _shipCountry;

        public string ShipCountry
        {
            get { return _shipCountry; }
            set
            {
                _shipCountry = value; 
                
            }
        }
        private string _product;

        public string Product
        {
            get { return _product; }
            set
            {
                _product = value; 
                
            }
        }
        private string _salesYear;

        public string SalesYear
        {
            get { return _salesYear; }
            set
            {
                _salesYear = value; 
                
            }
        }

    }
}
