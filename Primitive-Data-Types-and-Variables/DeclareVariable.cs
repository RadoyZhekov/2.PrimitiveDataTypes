using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
Submit the source code of your Visual Studio project as part of your homework submission.*/

namespace Primitive_Data_Types_and_Variables
{
    class DeclareVariable
    {
        static void Main(string[] args)
        {
           
            byte num1 = 97;
            sbyte num2 = -115;
            short num3 = -10000;
            ushort num4 = 52130;
            int num5 = 4825932;
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", num1,num2,num3,num4,num5);
            
            
        }
    }
}
