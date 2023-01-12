using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask17.Accounts
{
    internal class NormalAccount : IAccount
    {
        IAccount normalAccount;
        public NormalAccount(double balance)
        {
            Type = "Обычный";
            Balance = balance;
            normalAccount = this;
        }

        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            normalAccount.Interest = normalAccount.Balance * 0.4;
            if (normalAccount.Balance < 1000)
                normalAccount.Interest -= normalAccount.Balance * 0.2;

            if (normalAccount.Balance > 50000)
                normalAccount.Interest -= normalAccount.Balance * 0.4;
            Console.WriteLine($"Процентная ставка клиента ({normalAccount.Type}) :{normalAccount.Interest}");
        }
    }
}
