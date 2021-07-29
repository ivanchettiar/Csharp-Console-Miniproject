using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Account
    {
       int balance = 20000;
        
        public int Withdraw(int a)
        {
            return balance - a;
            
        }

        public int Deposit(int a)
        {
            return balance + a;

        }




    }
}
