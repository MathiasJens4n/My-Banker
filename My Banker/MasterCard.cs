using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    internal class MasterCard : Card, IExpireDate
    {
        public string ExpiryDate { get; set; }

        public MasterCard(BankAccount bankAccount) : base(bankAccount)
        {
            Prefix = new string[] { "51", "52", "53", "54", "55" };
            CardNumberLength = 16;
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
            DateTime date = DateTime.Now.AddYears(5);
            ExpiryDate = ($"{date.Month}/{date.Year}");
        }

        public override string ToString()
        {
            return $"Name: {BankAccount.Customer.Name}\nCard number: {CardNumber}\nAccount number: {BankAccount.AccountNumber}\nExpiration date: {ExpiryDate}";
        }

    }
}
