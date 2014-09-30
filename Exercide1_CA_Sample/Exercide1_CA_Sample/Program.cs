using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercide1_CA_Sample
{
    class Program
    {
        public static void Main()
        {
            CurrentAccount c1 = new CurrentAccount(500, 1111111);
            CurrentAccount c2 = new CurrentAccount(800, 2222222);
            //CurrentAccount c3 = new CurrentAccount(200, 3333333);
            //CurrentAccount c4 = new CurrentAccount(100, 4444444);

            c1.MakeDeposit(200);
            c1.MakeWithdrawal(400); // balance = 200

            c2.MakeWithdrawal(700);
            c2.MakeDeposit(400);
            c2.MakeDeposit(500); // balance 100

            Console.WriteLine("\n" + c1.ToString());
            foreach(AccountTransaction  at in c1.TransHistory)
            {
                if(at == null)
                {
                    break;
                }
                Console.WriteLine("Amount: " + at.Amount.ToString()+ " Transaction Type: " +at.Type.ToString());
            }
            Console.WriteLine("\nNew Account information");
            Console.ReadLine();

            Console.WriteLine("\n"+c2.ToString());

            foreach (AccountTransaction at in c2.TransHistory)
            {
                if (at == null)
                {
                    break;
                }
                Console.WriteLine("Amount: " + at.Amount.ToString() + " Transaction Type: " + at.Type.ToString());
            }
            Console.ReadLine();
        }
    }
}
