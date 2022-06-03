using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AccountAccess:DatabaseAccess
    {
        
        public string CheckAccDAL(PlayerAccount account)
        {
            string info =CheckAccount(account);
            return info;
        }
    }
}
