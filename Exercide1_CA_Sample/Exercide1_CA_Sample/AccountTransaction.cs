using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercide1_CA_Sample
{
    public enum TransactionType
    {
        Deposit, Withdrawal
    }

    // an account transaction
    public class AccountTransaction
    {
        private TransactionType type;		// deposit/withdrawal
        private double amount;			// amount concerned

        public TransactionType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        // constructor
        public AccountTransaction(TransactionType type, double amount)
        {
            this.type = type;
            this.amount = amount;
        }

        // return human readable String
        public override String ToString()
        {
            return "type: " + type + " amount: " + amount;
        }
    }

}
