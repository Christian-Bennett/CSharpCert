using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Code
{
    class BankAcct
    {
        private Object acctLock = new object();
        double Balance { get; set; }

        public BankAcct(double bal)
        {
            Balance = bal;

        }

        public double Withdraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine("Not enough funds");
                return Balance;
            }

            lock (acctLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Removed {0}. {1} Remaining", amt, (Balance - amt));
                    Balance -= amt;
                }
                return Balance;
            }

        }
        public void RemoveFunds()
        {
            Withdraw(1);
        }
    }
}
