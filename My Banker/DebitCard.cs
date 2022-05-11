using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    internal class DebitCard : Card
    {
        public DebitCard(BankAccount bankAccount) : base(bankAccount)
        {
            Prefix = new string[] { "2400" };
            CardNumberLength = 16;
            GenerateCardNumber();
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

        public override string ToString()
        {
            return $"Name: {BankAccount.Customer.Name}\nCard number: {CardNumber}\nAccount number: {BankAccount.AccountNumber}";
        }

    }
}
