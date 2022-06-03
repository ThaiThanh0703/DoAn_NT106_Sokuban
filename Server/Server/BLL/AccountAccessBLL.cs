using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class AccountAccessBLL
    {
        AccountAccess acc = new AccountAccess();
        public string CheckAcc(PlayerAccount account)
        {
            if (account.sUsername =="")
            {
                return "require_username";
            }    
            if (account.sPassword == "")
            {
                return "require_password";
            }
            string info = acc.CheckAccDAL(account);
            return info;
        }
    }
}
