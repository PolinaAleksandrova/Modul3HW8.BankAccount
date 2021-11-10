using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul3HW8.BankAccount.Models;
using Modul3HW8.BankAccount.Services.Abstractions;

namespace Modul3HW8.BankAccount.Services
{
    public class AccountService : IAccountService
    {
        private readonly Account _account;

        public AccountService(Account account)
        {
            _account = account;
            _account.Balance.ToTransfer += transfer => Console.WriteLine($" {transfer} $ transferred to the account {_account.Name}");
            _account.Balance.ToWithdraw += transfer => Console.WriteLine($" {transfer} $ withdrawn from the account {_account.Name}");
        }

        public void GetBalance()
        {
            Console.WriteLine($" Balance status: {_account.Balance.Sum} $");
        }

        public void Transfer(decimal sum)
        {
            _account.Balance.Transfer(sum);
        }

        public void Withdraw(decimal sum)
        {
            _account.Balance.Withdraw(sum);
        }
    }
}
