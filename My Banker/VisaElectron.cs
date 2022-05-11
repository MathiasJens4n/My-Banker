using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    internal class VisaElectron : Card, IExpireDate
    {
        public string ExpiryDate { get; set; }

        public VisaElectron(BankAccount bankAccount) : base(bankAccount)
        {
            Prefix = new string[] { "4026", "417500", "4508", "4844", "4913", "4917" };
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
