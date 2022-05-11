using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    internal abstract class Card
    {
        protected Random rnd = new Random();
        public BankAccount BankAccount { get; set; }
        protected int CardNumberLength { get; set; }
        protected string[] Prefix { get; set; }
        public string CardNumber { get; set; }
        public Card(BankAccount bankAccount)
        {
            BankAccount = bankAccount;
        }
        public abstract void GenerateCardNumber();

    }
}