using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW8.BankAccount.Models
{
    public class Balance
    {
        public Balance(decimal transfer)
        {
            Sum = transfer;
        }

        public delegate void Notify(decimal sum);

        public event Notify ToTransfer;

        public event Notify ToWithdraw;

        public decimal Sum { get; set; }

        public void Transfer(decimal transfer)
        {
            Sum += transfer;

            ToTransfer?.Invoke(transfer);
        }

        public void Withdraw(decimal transfer)
        {
            if (Sum >= transfer)
            {
                Sum -= transfer;
                ToWithdraw?.Invoke(transfer);
            }
        }
    }
}
