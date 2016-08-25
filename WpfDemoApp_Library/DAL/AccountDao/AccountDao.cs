using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppDemo_DTO.Account;
using WpfAppDemo_Library.DAL.AccountDao.Interface;
using WPFAppDemo_Library.Model;


namespace WpfAppDemo_Library.DAL.AccountDao
{
    public class AccountDao : IAccountDao
    {
        bool IAccountDao.GetLoginInfoDao(AccountDTO objAccountDTO)
        {
            using (NorthwindEntities objNorthwind = new NorthwindEntities())
            {
                return objNorthwind.Users.Any(o => o.Username.ToLower() == objAccountDTO.Username.ToLower() & o.Password == objAccountDTO.Password);
            }

        }
    }
}
