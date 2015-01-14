using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? value1 = null;

            double? value2 =null;
            Console.WriteLine("Value1 = {0}, Value2= {1}",value1,value2); 
            //null+13=null
            value1 = value1 + 13;
            value2 = value2 + 13.21;
            Console.WriteLine("Value1 +13={0}",value1);
            Console.WriteLine("Value2 + 13.21={0}",value2);
        }
    }
}
