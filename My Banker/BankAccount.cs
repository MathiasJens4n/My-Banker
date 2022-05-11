using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    internal class BankAccount
    {
        Random rnd = new Random();
        public Customer Customer { get; set; }
        public string AccountNumber { get; set; }
        public string RegNumber { get; set; } = "3520";
        public BankAccount(Customer customer)
        {
            Customer = customer;
            GenerateAccountNumber();
        }
        public void GenerateAccountNumber()
        {
            AccountNumber = RegNumber;
            for (int i = 0; i < 10; i++)
            {
                AccountNumber += rnd.Next(0, 10);
            }
        }


    }
}
