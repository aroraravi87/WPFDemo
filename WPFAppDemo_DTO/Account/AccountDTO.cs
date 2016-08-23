using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAppDemo_DTO.Account
{
    public class AccountDTO:IDisposable
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public System.DateTime CreatedDate { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
