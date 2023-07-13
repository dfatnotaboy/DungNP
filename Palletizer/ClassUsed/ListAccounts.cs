using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palletizer.ClassUsed
{
    public class ListAccountClass
    {
        private static ListAccountClass instance;
        public static ListAccountClass Instance 
        {
            
            get
            {
                if (instance==null)
                
                    instance = new ListAccountClass();
                    return instance;
                
            } 
            set => instance = value; 
        
        }


        List<AccountsClass>listAccounts ;
        public List<AccountsClass> ListAccounts 
        { 
            get => listAccounts; 
            set => listAccounts = value; 
        }
        public ListAccountClass() 
        {
            ListAccounts = new List<AccountsClass>();
            ListAccounts.Add(new AccountsClass("Vias", "1108"));
        }
      
        
    }
}