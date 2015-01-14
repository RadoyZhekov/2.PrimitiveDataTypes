using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double number1=double.Parse(Console.ReadLine());
            double number2 =double.Parse(Console.ReadLine());
            double difference = Math.Abs(number1 - number2);
            double eps = 0.000001;
            if (difference > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
