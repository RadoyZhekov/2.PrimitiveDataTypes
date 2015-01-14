using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.*/

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            int num = 42;
            Console.WriteLine((char)num);
            
        }
    }
}
/*const char variable = '\u002a';
		Console.WriteLine(variable);*/