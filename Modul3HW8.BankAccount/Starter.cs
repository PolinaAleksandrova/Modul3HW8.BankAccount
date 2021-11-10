using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Modul3HW8.BankAccount.Services;
using Modul3HW8.BankAccount.Services.Abstractions;

namespace Modul3HW8.BankAccount
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAccountService, AccountService>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var application = serviceProvider.GetService<Application>();

            application.Start();
        }
    }
}
