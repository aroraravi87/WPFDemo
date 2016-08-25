using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppDemo_DTO.Account;
using WpfAppDemo_Library.DAL.AccountDao.Interface;
using WpfAppDemo_Library.DAL.DashboardDao.Interface;
using WpfAppDemo_Library.Manager.AccountManager.Interface;
using WPFAppDemo_DTO.DashBoard;
using WPFAppDemo_Library.Common;


namespace WpfAppDemo_Library.Manager.DashboardManager
{
    public class DashboardManager : IDashboardManager
    {
        private IDashboardDao _objAccountDao;

        public DashboardManager(IDashboardDao ObjDashboardDao)
        {
            _objAccountDao = ObjDashboardDao;
        }

        public IList<SalesDTO> GetProductSales()
        {
            return _objAccountDao.GetProductSales().ToObservableCollection();
        }
        public IList<ProductDTO> GetProductList()
        {
            return _objAccountDao.GetProductList().ToObservableCollection();
        }
    }
}
