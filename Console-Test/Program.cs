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

            //Relational Operators: > < >= <= == !=
            //Logical Operators: && (AND) || (OR) ^ (XOR) ! (NOT)

            int age = rand.Next(1, 101);
            Console.WriteLine(age);

            //IF statements
            if (age >= 5 && age <= 7)
            {
                Console.WriteLine("Go to Elementary School");
            } else if (age > 7 && age < 13)
            {
                Console.WriteLine("Go to Middle School");
            } else
            {
                Console.WriteLine("Go to High School");
            }

            if (age < 14 || age > 67)
            {
                Console.WriteLine("You Shouldn't Work");
            }

            Console.WriteLine("! true: " + !true);

            //Ternary - Condition ? ifTrue : ifFalse
            bool canDrive = age >= 18 ? true : false;

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    //Goto jumps to the code block you specify (It's gonna kick you out of the switch statement)
                    goto Checkpoint1;
                default:
                    Console.WriteLine("Child");
                    break;
            }

        Checkpoint1:
            Console.WriteLine("I'm printed from outside the switch statement");

            Console.WriteLine("-------------------------------------------------------");

            int j = 0;
            
            while(j < 10)
            {
                if (j == 7)
                {
                    j++;
                    continue;
                }
                //^^^ Jump back to the while header 

                if (j == 9)
                    break;
                //// ^^ Jump out of the loop

                if (j % 2 > 0)
                    Console.WriteLine(j);

                j++;
            }

            Console.WriteLine("-------------------------------------------------------");

            //DO While: The body of do is executed at least one time
            string guess;

            do
            {
                Console.WriteLine("Guess a number");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));

            Console.WriteLine("-------------------------------------------------------");

            //FOR Loop: All the conditional and counter stuff is in the heading
            for (int k = 0; k < 10; k++)
            {
                if(k % 2 != 0)
                {
                    Console.WriteLine(k);
                }
            }

            Console.WriteLine("-------------------------------------------------------");

            //FOREACH: Used to iterate over list, arrays, maps and collections
            string randString = "Example Random String";

            foreach (char c in randString)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("-------------------------------------------------------");

            //Strings
            //Escape Sequences: Allow you to enter special chars in strings
            //      \' \" \\ \b \n \t
            string sampleString = "Some random words";

            //Prints wether a string is empty or null
            Console.WriteLine("Is Empty: " + String.IsNullOrEmpty(sampleString));
            //Prints wether a string is null or filled with white space
            Console.WriteLine("Is Empty: " + String.IsNullOrWhiteSpace(sampleString));

            Console.WriteLine("String Length: " + sampleString.Length);
            //Returns the position of a certain string/char inside of another string | returns -1 if it doesn't find it 
            Console.WriteLine("Index of 'random': " + sampleString.IndexOf("random"));
            //Returns a substring of the parent string when given the index of the first letter and the length of the word

            Console.WriteLine("2nd word: " + sampleString.Substring(5, 6));
            //Returns true if the parent string is equals to the argument string
            Console.WriteLine("Strings Equal: " + sampleString.Equals(randString));
            //Returns true if the String starts with the argument string

            Console.WriteLine("Starts with \"Example Random\": " + randString.StartsWith("Example Random"));
            //Returns true if the String ends with the argument string
            Console.WriteLine("Ends with \"Example String\": " + randString.EndsWith("Example String"));

            //Removes white space at the beginning or at the end of a string
            sampleString = sampleString.Trim(); //TrimEnd TrimStart

            //Replaces a substring of the parent string with another string
            sampleString = sampleString.Replace("words", "characters");

            //Removes a substring of length equals to the second parameter starting from the passed index (first parameter)
            sampleString = sampleString.Remove(0, 4);

            //Array of strings
            string[] words = new string[6] {"I", "Suck", "At", "Drawing", "Textures", ":("};
            //Join a string array into one single string
            Console.WriteLine("Joined String Array: " + String.Join(" ", words));

            Console.WriteLine("-------------------------------------------------------");

            //Formatting Strings
            string formatted = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 4.99, 15.567, .56, 1000);
            Console.WriteLine("Formatted Strings examples: " + formatted);

                        Console.WriteLine("-------------------------------------------------------");

            //String Builder
            //Used when you want to edit a string without creating a new one
            StringBuilder sb = new StringBuilder();
            //Append new strings - (AppendLine is the version that appends a \n at the end automatically)
            sb.Append("This is the first Sentence.");
            sb.AppendFormat("My Nick is {0} and I am a {1} developer", "Davoleo", "C#");
            //Empties the whole StringBuilder Buffer
            //sb.Clear();
            //Replaces a string with another one in all the occurrences in the StringBuilder
            sb.Replace("e", "E");
            //Removes chars from index 5 (included) to index 7 (excluded)
            sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());



        }
    }
}
