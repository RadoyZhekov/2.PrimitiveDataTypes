using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.*/
namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 10;
            Console.WriteLine("Before first: {0} , second: {1}", first , second);
            int third = first;
            first = second;
            second = third;
            Console.WriteLine("After first: {0} , second: {1}", first, second);

        }
    }
}
