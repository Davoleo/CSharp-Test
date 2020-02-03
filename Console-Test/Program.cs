using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

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
            //Converts the StringBuilder to a String and writes it on the console
            Console.WriteLine(sb.ToString());

            Console.WriteLine("-------------------------------------------------------");

            //Arrays
            int[] randArray;
            int[] randFixedArray = new int[5];
            int[] literalArray = {1, 2, 3, 4, 5};

            //Returns the number of items in the array
            Console.WriteLine("Array Length: " + literalArray.Length);
            //Returns the first item of an array
            Console.WriteLine("First Item: " + literalArray[0]);

            //Loop through arrays

            //Classic For loop with array length
            for (int k = 0; k < literalArray.Length; k++)
            {
                Console.WriteLine("{0} : {1}", k, literalArray[k]);
            }
            //For Each
            foreach (int num in literalArray)
            {
                Console.WriteLine(num);
            }

            //Returns the index of a specific array element
            Console.WriteLine("Index of 3: " + Array.IndexOf(literalArray, 3));

            string[] names = {"Shana", "Alastor", "Wilhelmina", "Decarabia", "Fecor", "Hecate", "Sydonnay"};
            //Joins all the items of an array dividing them with a custom separator
            string nameCollectionString = string.Join(", ", names);

            names = nameCollectionString.Split(',');

            //Multidimensional Arrays
            //Two dimensional empty array of length 5*3
            int[,] multArray = new int[5, 3];

            //Literal Init
            int[,] multArray2 = {{0, 1}, {2, 3}, {4, 5}};

            foreach (int num in multArray2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-------------------------------------------------------");

            //Lists: Dynamic Arrays
            List<int> numList = new List<int>();

            //Adds a Single item to the list
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            //Adds a range of items to the list (in some kind of collection form)
            int[] numArray = {1, 2, 3, 4};
            numList.AddRange(numArray);

            //Removes All the items in the list
            //numList.Clear();

            //Init a list with an array (aka create a list from an array)
            List<int> numList2 = new List<int>(numArray);

            //Insert an item in a specific index
            numList.Insert(1, 10);

            //Removes the first occurance of the argument in the list, from the list
            numList.Remove(5);
            //Removes the item at the index 2
            numList.RemoveAt(2);

            for (var l = 0; l < numList.Count; l++)
            {
                Console.WriteLine(numList[l]);
            }

            //Returns the index of the first occurance of the passed item (returns -1 if it doesn't find any)
            Console.WriteLine("4 is in index " + numList2.IndexOf(4));

            Console.WriteLine("is 5 in the list " + numList.Contains(5));

            List<string> stringList = new List<string>(new string[] {"Davoleo", "Matpac", "Pierknight"});
            //case insensitive String comparison
            Console.WriteLine("Davoleo in list " + stringList.Contains("davoleo", StringComparer.OrdinalIgnoreCase));

            //Sorts the list alphabetically or numerically depending on the contents
            numList.Sort();

            Console.WriteLine("-------------------------------------------------------");
            
            //Exception Handling
            //Try and Catch Structure
            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1}", num, 10 / num);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Can't divide by 0");
                //Prints the name of the exception
                Console.WriteLine(e.GetType().Name);
                //Prints a small description of the exception
                Console.WriteLine(e.Message);
                //Throws the same exception again
                //throw e;
                //Throws another new Exception
                throw new InvalidOperationException("Operation Failed", e);
            }
            catch (Exception e)
            {
                //This Catches all the exceptions
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("-------------------------------------------------------");

            //Classes and Objects
            Animal botolo = new Animal(0.5, 6, "Meeer", "Botolo");

            Console.WriteLine("{0} says {1}", botolo.Name, botolo.Sound);
            Console.WriteLine(botolo.ToString());
            Console.WriteLine(Animal.GetCount());

            Console.WriteLine("-------------------------------------------------------");

            //Method Overloading test
            //This Calls the int version
            Console.WriteLine("1 + 25 = " + GetSum(1, 25));
            //This Calls the double version
            //Passing parameters in another order
            Console.WriteLine("7.64 + 9.24 = " + GetSum(num2: 7.64, num1: 9.24));

            Console.WriteLine("-------------------------------------------------------");

            //Object Initializer - Assigning values to the fields manually
            Animal epicAnimal = new Animal()
            {
                Name = "Grover",
                Height = 13,
                Weight = 11,
                Sound = "GRRR"
            };
            Console.WriteLine(epicAnimal.ToString());


        }

        class Animal
        {
            //Access Limits
            //public - protected - private
            // {get; set;} automatically defines getters and setters for the field
            public double Height { get; set; }
            public double Weight { get; set; }
            public string Sound { get; set; }
            private string name;

            //custom getters/setters (properties)
            public string Name
            {
                get { return name; }
                set { this.name = value; }
            }

            //Constructors
            //The default constructor has no parameters
            public Animal()
            {
                this.Height = 0;
                this.Weight = 0;
                this.Sound = "NoSound";
                this.Name = "NoName";
                count++;
            }

            public Animal(double height, double weight, string sound, string name)
            {
                this.Height = height;
                this.Weight = weight;
                this.Sound = sound;
                this.Name = name;
                count++;
            }

            //Static fields and methods - common between instances of this class
            private static int count = 0;
            public static int GetCount() {
                return count;
            }

            //Overrides a method in the superclass (needs the override keyword)
            public override string ToString()
            {
                return String.Format("{0} is {1} meters tall, weighs {2} kg and makes this sound: {3}", name, Height,
                    Weight, Sound);
            }
        }

        //Method Overloading
        //Same Method name - Different Method Signature (multiple versions of the same method)
        public static int GetSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public static double GetSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }

        //Subclass - C#: Inheritance 
        class Cat : Animal
        {
            private string favFood { get; set; }

            public Cat() : base()
            {
                this.favFood = "none";
            }

            public Cat(double height, double weight, string name, string sound, string favFood) : 
                base(height, weight, sound, name)
            {
                this.favFood = favFood;
            }

            public override string ToString()
            {
                return String.Format("{0} is {1} tall, weighs {2} and likes to say {3} and eats {4}", Name, Height, Weight, Sound, favFood);
            }
        }

        //Polymorphism ----------------------------------------------------------
        abstract class Shape
        {
            public abstract double Area();

            public void LogShapeInfo()
            {
                Console.WriteLine(this.ToString());
            }
        }

        public interface ICountouredShape
        {
            double Perimter();
        }

        class Rectangle : Shape, ICountouredShape
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public override double Area()
            {
                return width * height;
            }

            public double Perimter()
            {
                return (width + height) * 2;
            }
        }

        class Triangle : Shape
        {
            private double _base;
            private double height;

            public Triangle(double _base, double height)
            {
                this._base = _base;
                this.height = height;
            }

            public override double Area()
            {
                return (_base * height) / 2;
            }
        }
    }
}
