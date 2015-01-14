using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
                                                   ©

                                                  © ©

                                                 ©   ©

                                                © © © ©
 */
namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00A9';
            Console.WriteLine("   {0}", symbol);
            Console.WriteLine();
            Console.WriteLine("  {0} {0}",symbol);
            Console.WriteLine();
            Console.WriteLine(" {0} {0} {0}",symbol);
            Console.WriteLine();
            Console.WriteLine("{0} {0} {0} {0}",symbol);
        }
       
    }
}
