using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW8.BankAccount.Models
{
    public class Account
    {
        public Account(string name, Balance balance)
        {
            Name = name;
            Balance = balance;
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }

        public Balance Balance { get; set; }

        public Guid Id { get; set; }
    }
}
