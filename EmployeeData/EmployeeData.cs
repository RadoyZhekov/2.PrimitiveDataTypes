using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter second name:");
                    string secondName = Console.ReadLine();
                    Console.WriteLine("Enter your age:");
                    byte age = byte.Parse(Console.ReadLine());
                    Console.WriteLine(@"Enter your gender - ""m"" for Male , and ""f"" for female:");
                    char gender = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your Id Number");
                    int IdNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your Employee Number");
                    int EmployeeNumber = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong data format!");
                    
                }
                
            }


        }
    }
}
