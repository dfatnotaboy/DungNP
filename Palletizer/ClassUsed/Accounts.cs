using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Web;

namespace Palletizer.ClassUsed
{
    public class AccountsClass // tạo để biết xem trong tài khoản có thuộc tính gì
    {
        private string userNameClass;
        public string UserNameClass 
        { 
            get => userNameClass; 
            set => userNameClass = value; 
        }
        private string passWordClass;
        public string PassWordClass 
        { 
            get => passWordClass; 
            set => passWordClass = value; 
        }
      

        public AccountsClass(string username, string password) 
        {
            
            this .userNameClass = username;
            this .passWordClass = password;
        }
    }

}
