using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            // Example Single-line Comment
            /* Example 
             * Multiline
             * Comment
             */


            //Hello World
            Console.WriteLine("Hello World");

            //Get user input
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //Data Types
            bool canVote = true;
            char fumoffu = '%';

            int maxInt = int.MaxValue;
            long maxLong = long.MaxValue;
            decimal maxDecimal = decimal.MaxValue;
            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int: " + maxInt);

            //Implicit type variable declaration
            var sampleVar = "SampleString";

            //You can't change its type after declaration though
            //sampleVar = 2;

            Console.WriteLine("sampleVar is a {0}", sampleVar.GetTypeCode());
            Console.WriteLine("-------------------------------------------------------");

            //Arithmetics
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;

            Console.WriteLine("i++ = " + i++);
            Console.WriteLine("++i = " + ++i);
            Console.WriteLine("i-- = " + i--);
            Console.WriteLine("--i = " + --i);

            Console.WriteLine("-------------------------------------------------------");
            //Some Math Static Functions
            //acos, asin, atan, atan2, cos, cosh, exp, log, sin, sinh, tan, tanh
            double num1 = 10.5;
            double num2 = 15;

            Console.WriteLine("Abs(num1): " + Math.Abs(num1));
            Console.WriteLine("Ceiling(num1): " + Math.Ceiling(num1));
            Console.WriteLine("Floor(num1): " + Math.Floor(num1));
            Console.WriteLine("Max(num1, num2): " + Math.Max(num1, num2));
            Console.WriteLine("Min(num1, num2): " + Math.Min(num1, num2));
            Console.WriteLine("Pow(num1): " + Math.Pow(num1, num2));
            Console.WriteLine("Round(num1): " + Math.Round(num1));
            Console.WriteLine("Sqrt(num1): " + Math.Sqrt(num1));

            Console.WriteLine("-------------------------------------------------------");

            //Casting
            const double PI = 3.14;
            int intPI = (int)PI;

            //Generating Random Numbers
            Random rand = new Random();
            Console.WriteLine("Random number between 1 and 10: " + rand.Next(1, 11));


        }
    }
}
