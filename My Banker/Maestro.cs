using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    internal class Maestro : Card, IExpireDate
    {
        public string ExpiryDate { get; set; }

        public Maestro(BankAccount bankAccount) : base(bankAccount)
        {
            Prefix = new string[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
            CardNumberLength = 19;
            GenerateCardNumber();
            CalcExpireDate();
        }
        public override void GenerateCardNumber()
        {
            int prefixRnd = rnd.Next(0, Prefix.Length);
            CardNumber = Prefix[prefixRnd];
            for (int i = Prefix[prefixRnd].Length; i < CardNumberLength; i++)
            {
                CardNumber += rnd.Next(0, 10);
            }
        }
        public void CalcExpireDate()
        {
            DateTime date = DateTime.Now.AddYears(5).AddMonths(8);
            ExpiryDate = ($"{date.Month}/{date.Year}");
        }

        public override string ToString()
        {
            return $"Name: {BankAccount.Customer.Name}\nCard number: {CardNumber}\nAccount number: {BankAccount.AccountNumber}\nExpiration date: {ExpiryDate}";
        }

    }
}
