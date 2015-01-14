using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            
            float fnumber = 12.345f;
            float fnumber2 = 3456.091f;
            double dnumber = 34.567839023;
            double dnumber2 = 8923.1234857;

            Console.WriteLine("{0} This type is {1}", fnumber, fnumber.GetType());
            Console.WriteLine("{0} This type is {1}", fnumber2, fnumber2.GetType());
            Console.WriteLine("{0} This type is {1}", dnumber, dnumber.GetType());
            Console.WriteLine("{0} This type is {1}", dnumber2, dnumber2.GetType());

        }
    }
}