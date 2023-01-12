using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask17.Accounts
{
    internal class SalaryAccount : IAccount
    {
        IAccount salaryAccount;
        public SalaryAccount(double balance)
        {
            Type = "Зарплатный";
            Balance = balance;
            salaryAccount = this;
        }

        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            salaryAccount.Interest = salaryAccount.Balance * 0.5;
            Console.WriteLine($"Процентная ставка клиента ({salaryAccount.Type}) :{salaryAccount.Interest}");
        }
    }
}
