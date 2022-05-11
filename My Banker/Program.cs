using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer mathias = new Customer("Mathias");
            BankAccount bankAccount = new BankAccount(mathias);

            DebitCard debitCard = new DebitCard(bankAccount);
            Maestro maestro = new Maestro(bankAccount);
            MasterCard masterCard = new MasterCard(bankAccount);
            Visa visa = new Visa(bankAccount);
            VisaElectron visaElectron = new VisaElectron(bankAccount);
            List<Card> cards = new List<Card>() { debitCard, maestro, masterCard, visa, visaElectron };
            
            foreach (Card card in cards)
            {
                Console.WriteLine($"\n{card.GetType().Name}\n{card}");
            }

            Console.ReadKey();
        }
    }
}
