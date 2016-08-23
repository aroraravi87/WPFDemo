using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppDemo_DTO.Account;

namespace WpfAppDemo_Library.DAL.AccountDao.Interface
{
    public interface IAccountDao
    {
        bool GetLoginInfoDao(AccountDTO objAccountDTO);

    }
}
