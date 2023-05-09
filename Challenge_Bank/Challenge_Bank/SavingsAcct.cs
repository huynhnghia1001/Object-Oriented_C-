﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Bank
{
    public class SavingsAcct : BankAccount
    {
        private int _withdrawcount = 0;
        private const decimal WITHDRAW_CHARGE = 2.0m;
        private const int WITHDRAW_LIMIT = 3;

        public SavingsAcct(string fname, string lname, decimal interest, decimal initial)
            :base(fname,lname,initial){
            InterestRate = interest;
        }
        public decimal InterestRate
        {
            get; set;
        }
        public void ApplyInterest()
        {
            Balance += (Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("Attempt to overdraw savings - denied");
            }
            else
            {
                base.Withdraw(amount);
                _withdrawcount++;
                if(_withdrawcount > WITHDRAW_LIMIT)
                {
                    Console.WriteLine("More than 3 withdrawals - extra charge");
                    base.Withdraw(WITHDRAW_LIMIT);
                }

            }
        }
    }
    
}
