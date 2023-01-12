using FinalTask17.Accounts;

namespace FinalTask17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount salaryClient = new SalaryAccount(500);
            IAccount normalClient = new NormalAccount(500);
            salaryClient.CalculateInterest();
            normalClient.CalculateInterest();
        }
    }
}