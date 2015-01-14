using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/
namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName="John";
            string middleName="Smith";
            string lastName="Doe";
            decimal balance=1700.44m;
            string bankName="ProCredit Bank";
            string IBAN="PRCBG5490224094212";
            string firstCard="1234567890123456";
            string secondCard="1234567890123453";
            string thirdCard = "1234567890123451";
            Console.WriteLine("first name is of type: {0}",firstName.GetType());
            Console.WriteLine("first name is of type: {0}", middleName.GetType());
            Console.WriteLine("first name is of type: {0}", lastName.GetType());
            Console.WriteLine("first name is of type: {0}", balance.GetType());
            Console.WriteLine("first name is of type: {0}", bankName.GetType());
            Console.WriteLine("first name is of type: {0}", IBAN.GetType());
            Console.WriteLine("first name is of type: {0}", firstCard.GetType());
            Console.WriteLine("first name is of type: {0}", secondCard.GetType());
            Console.WriteLine("first name is of type: {0}", thirdCard.GetType());



        }
    }
}
