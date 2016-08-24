using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppDemo_DTO.Account;
using WpfAppDemo_Library.DAL.AccountDao.Interface;
using WpfAppDemo_Library.DAL.DashboardDao.Interface;
using WpfAppDemo_Library.Model;

namespace WpfAppDemo_Library.DAL.DashboardDao
{
    public class DashboardDao : IDashboardDao
    {
   
        public IList<SalesDTO> GetProductSales()
        {
            using (NorthwindEntities objNorthwind = new NorthwindEntities())
            {
                return null;
            }
        }
    }
}
