using System;
namespace LeetCode
{
    public class simple_bank_system
    {
        public class Bank
        {
            long[] balance;

            public Bank(long[] balance)
            {
                this.balance = balance;
            }

            public bool Transfer(int account1, int account2, long money)
            {
                if (account1 > balance.Length || account2 > balance.Length || balance[account1 - 1] < money)
                {
                    return false;
                }
                balance[account1 - 1] -= money;
                balance[account2 - 1] += money;
                return true;
            }

            public bool Deposit(int account, long money)
            {
                if (account > balance.Length)
                {
                    return false;
                }
                balance[account - 1] += money;
                return true;
            }

            public bool Withdraw(int account, long money)
            {
                if (account > balance.Length || balance[account - 1] < money)
                {
                    return false;
                }
                balance[account - 1] -= money;
                return true;
            }
        }
    }
}
