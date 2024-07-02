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
            int userNum = Int32.Parse(Console.ReadLine());
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
