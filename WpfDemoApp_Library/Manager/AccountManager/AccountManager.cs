using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppDemo_DTO.Account;
using WpfAppDemo_Library.DAL.AccountDao.Interface;
using WpfAppDemo_Library.Manager.AccountManager.Interface;

namespace WpfAppDemo_Library.Manager.AccountManager
{
    public class AccountManager: IAccountManager
    {
        private IAccountDao _objAccountDao;

        public AccountManager(IAccountDao ObjAccountDao)
        {
            _objAccountDao = ObjAccountDao;
        }
        public bool GetLoginInfo(AccountDTO objLoginDTO)
        {
            return _objAccountDao.GetLoginInfoDao(objLoginDTO);
        }
    }
}
