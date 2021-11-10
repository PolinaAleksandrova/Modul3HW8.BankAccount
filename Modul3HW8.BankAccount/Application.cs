using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul3HW8.BankAccount.Models;
using Modul3HW8.BankAccount.Services;

namespace Modul3HW8.BankAccount
{
    public class Application
    {
        public void Start()
        {
            var account = new Account("User", new Balance(5));
            var accountService = new AccountService(account);

            accountService.Withdraw(150);
            accountService.GetBalance();
            accountService.Transfer(50);
            accountService.GetBalance();
            accountService.Withdraw(100);
            accountService.Withdraw(10);
            accountService.GetBalance();
            Console.Read();
        }
    }
}
