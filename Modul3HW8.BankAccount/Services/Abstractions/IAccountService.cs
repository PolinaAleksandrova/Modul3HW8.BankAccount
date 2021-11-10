using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW8.BankAccount.Services.Abstractions
{
    public interface IAccountService
    {
        void Transfer(decimal sum);
        void GetBalance();
        void Withdraw(decimal sum);
    }
}
