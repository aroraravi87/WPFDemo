using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo_Library.Manager.AccountManager.Interface;
using WPFAppDemo_DTO.Account;
using WPFAppDemo_Unity.UnityBase;
using WPFAppDemo_Library.Common;

namespace WpfAppDemo.ViewModel
{
    public class DashBoardViewModel
    {
        private IDashboardManager _objDashboardManager;

        private ObservableCollection<SalesDTO> _salesDataCollection;
        public DashBoardViewModel()
        {
            _objDashboardManager = CustomUnityContainer.Resolve<IDashboardManager>();
            GetSalesReport();
        }

       

        public ObservableCollection<SalesDTO> SalesDataCollection
        {
            get { return _salesDataCollection; }
            set { _salesDataCollection = value; }
        }


        private void GetSalesReport()
        {
            SalesDataCollection=_objDashboardManager.GetProductSales().ToObservableCollection();
           
        }
    }
}
