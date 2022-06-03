using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Server_ : Form
    {
        PlayerAccount acc= new PlayerAccount();
        AccountAccessBLL account=new AccountAccessBLL();
        public Server_()
        {
            InitializeComponent();
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.DeepSkyBlue;
        }

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Aqua;
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string CheckAccess (string username,string password)
        {
            acc.sUsername = username;
            acc.sPassword = password;
            string getuser = account.CheckAcc(acc);
            switch (getuser)
            {
                case "require_username":
                    return "ERR_ACC01";
                case "require_password":
                    return "ERR_ACC02";
                case "incorrect_data":
                    return "ERR_ACC03";

            }
            return "SUCC_ACC";
        }
    }
}
