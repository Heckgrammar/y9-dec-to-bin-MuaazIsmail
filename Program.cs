using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer you want to convert to binary");
            bool validity = false;
            int userNum = 0;
            string numString = "  ";
            while (validity == false)
            {
                int errors = 0;
                numString = Console.ReadLine();
                bool isNum = int.TryParse(numString, out userNum);
                if (isNum == false)
                {
                    errors++;
                    Console.WriteLine("The input should be a numerical value");
                }
                else
                {
                    if (userNum < 1)
                    {
                        errors++;
                        Console.WriteLine("The number must be greater than 0");
                    }
                }
                if (errors == 0)
                {
                    validity = true;
                }
            }
            Console.WriteLine(userNum + " is " + (numberConversion(userNum, 2)) + " in binary");
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            int remainder = 0;
            string result = "";
            while (number > 0)
            {
                remainder = number % numberbase;
                number = number / numberbase;
                result = remainder + result;
            }
            return result;
        }
    }
}
