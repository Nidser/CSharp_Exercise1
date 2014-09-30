using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercide1_CA_Sample
{
    public abstract class BankAccount
    {
        private int accountNumber;
        public double accountBalance { get; set; }
 
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        protected BankAccount(int accNum)
        {
            accountNumber = accNum;
            accountBalance = 0;
        }

        //Methods
        public abstract void MakeDeposit(double amount);

        public abstract double MakeWithdrawal(double amount);
    }
}
