﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

Note: You may need to use for-loops (learn in Internet how).*/

namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int rows = 0;
            for (int i = 0; i < 255; i++)
            {
                rows++;
                Console.Write("{0} => {1} ", i, (char)i);
                if (rows == 7)
                {
                    rows = 0;
                    Console.WriteLine();
                }
            }
        }
    }
}
