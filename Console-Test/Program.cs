using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Console_Test.ElectronicDevice;
using Console_Test.OOPTest;
using Console_Test.Shapes;

namespace Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Basics

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

            #endregion

            #region Conditionals and Loops

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

            #endregion

            #region Strings & Arrays

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

            #endregion
            
            #region Exceptions

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

            #endregion

            #region OOP

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

            Console.WriteLine("-------------------------------------------------------");
            //Polymorphism 
            Shape rect = new Rectangle(5, 8);
            Shape tri = new Triangle(8, 3);
            Shape circle = new Circle(5);

            //Array of different kinds of shapes
            Shape[] shapeArray = {rect, tri, circle};

            foreach (var shape in shapeArray)
            {
                shape.LogShapeInfo();
            }
            Console.WriteLine("***");

            Console.WriteLine("Rect Area: " + rect.Area());
            Console.WriteLine("Tri Area: " + tri.Area());
            Console.WriteLine("Circle Area: " + circle.Area());
            Console.WriteLine("tri is a Triangle: " + (tri is Triangle));
            Console.WriteLine("rect is a Rectangle: " + ((rect as Rectangle) != null));
            Console.WriteLine("-------------------------------------------------------");

            //Operator Overloading for objects
            Rectangle combinedRectangle = new Rectangle(6, 10) + (Rectangle) rect;
            Console.WriteLine("combinedRectangle Area: " + combinedRectangle.Area());

            Console.WriteLine("-------------------------------------------------------");

            //Interfaces
            IElettronicDevice TV = TVRemote.GetDevice();
            PowerButton powerButton = new PowerButton(TV);
            powerButton.Execute();
            powerButton.Undo();

            Console.WriteLine("-------------------------------------------------------");
            
            //Generics - Classes that can be used with any kind of object
            SimpleMapEntry<int, string> davPass = new SimpleMapEntry<int, string>(333, "Davoleo");

            davPass.ShowData();

            //Generics work with multiple data types
            int firstInt = 5, secondInt = 4;
            GetSum(ref firstInt, ref secondInt);
            string firstString = firstInt.ToString();
            string secondString = secondInt.ToString();
            GetSum(ref firstString, ref secondString);

            Rectangle<int> rect1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rect1.GetArea());
            Rectangle<string> rect2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rect2.GetArea());

            Console.WriteLine("-------------------------------------------------------");

            Temperature waveTemp = Temperature.WARM;

            switch (waveTemp)
            {
                case Temperature.FREEZE:
                    Console.WriteLine("Freezing Temperature"); 
                    break;
                case Temperature.LOW:
                    Console.WriteLine("Low Temperature");
                    break;
                case Temperature.WARM:
                    Console.WriteLine("Warm Temperature");
                    break;
                case Temperature.HOT: 
                    Console.WriteLine("Hot Temperature");
                    break;
                case Temperature.SEARING:
                    Console.WriteLine("EPIC Temperature, everything Sublimates");
                    break;
                default:
                    Console.WriteLine("Invalid Temperature");
                    break;
            }

            Console.WriteLine("-------------------------------------------------------");

            //STRUCTS
            Customer davoleo = new Customer();
            davoleo.createCustomer("Davoleo", 55.80, 111);
            davoleo.printInfo();

            Console.WriteLine("-------------------------------------------------------");
            //DELEGATES - Passing methods to other methods as parameters

            //Anonymous method of type EvaluateExpression
            EvaluateExpression add = delegate(double n1, double n2) { return n1 + n2; };
            //Direct Delegate Assignment
            EvaluateExpression substract = (n1, n2) => { return n1 + n2; };
            EvaluateExpression multiply = delegate(double n1, double n2) { return n1 * n2; };

            //Calls both the delegates
            EvaluateExpression subtractMultuply = substract + multiply;

            Console.WriteLine("5 + 10 = " + add(5, 10));
            Console.WriteLine("5 * 10 = " + multiply(5, 10));
            Console.WriteLine("Subtract & Multiply 10 & 4: " + subtractMultuply(10, 4));

            //Lamda expressions - Anonymous functions
            Func<int, int, int> subtract = (x, y) => x - y;
            Console.WriteLine("5 - 10 = " + subtract.Invoke(5, 10));

            List<int> nums = new List<int>{3, 6, 9, 12, 15, 18, 21, 24, 27, 30};
            List<int> oddNumbers = nums.Where((n) => n % 2 == 1).ToList();

            foreach (var oddNumber in oddNumbers)
            {
                Console.Write(oddNumber + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");

            #endregion

            //File I/O
            string[] nicks = {"Davoleo", "Matpac", "Pierknight", "gesudio"};

            using (StreamWriter writer = new StreamWriter("nicknames.txt"))
            {
                foreach (var nick in nicks)
                {
                    writer.WriteLine(nick);
                }
            }

            using (StreamReader reader = new StreamReader("nicknames.txt"))
            {
                string user;
                while ((user = reader.ReadLine()) != null)
                {
                    Console.WriteLine(user);
                }
            }

            Console.WriteLine("-------------------------------------------------------");
            
            //OOP Game test
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior bob = new Warrior("Bob", 1000, 120, 40);

            Console.WriteLine("Disabled");
            //Battle.StartFight(maximus, bob);

            Console.WriteLine("-------------------------------------------------------");

            //Collections ----

            #region ArrayList

            //You can add different kind of objects ArrayLists
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Bob");
            arrayList.Add(43);

            //Number of items in the arraylist
            Console.WriteLine("ArrayList Count: " + arrayList.Count);
            //Capacity is always double the count (?)
            Console.WriteLine("ArrayList Capacity: " + arrayList.Capacity);

            ArrayList arrayList2 = new ArrayList();
            //Add an array to the ArrayList
            arrayList2.AddRange(new object[] {"Jeff", "Dave", "Egg", "Edge"});

            arrayList.AddRange(arrayList2);

            //Sort items in natural order
            arrayList2.Sort();
            //Reverse the order of items
            arrayList2.Reverse();

            //Insert some item at a specific index
            arrayList2.Insert(1, "PI");

            //Sub-Arraylist made of some of the items in the original arraylist
            ArrayList range = arrayList2.GetRange(0, 2);

            Console.WriteLine("arrayList object ---");
            foreach (object o in arrayList)
            {
                Console.Write(o + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("arrayList2 object ---");
            foreach (object o in arrayList2)
            {
                Console.Write(o + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("range object ----");
            foreach (object o in range)
            {
                Console.Write(o + "\t");
            }
            Console.WriteLine();

            //Remove the item at the 0 index
            //arrayList2.RemoveAt(0);

            //Removes the first 2 items starting from index 0
            //arrayList2.RemoveRange(0, 2);

            //Return the index of a specific object - if it doesn't find any it returns -1
            Console.WriteLine("Index of Edge: " + arrayList2.IndexOf("Edge"));

            //Converting ArrayLists to arrays
            string[] array = (string[]) arrayList2.ToArray(typeof(string));

            //Converting back to Arraylist
            ArrayList listFromArray = new ArrayList(array);

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region Dictionary

            //Stores a list of key-value pairs
            Dictionary<string, string> langsProjs = new Dictionary<string, string>();

            //Add A Key-Value Pair
            langsProjs.Add("C#", "CSharp-Test");
            langsProjs.Add("Java", "Metallurgy 4: Reforged");
            langsProjs.Add("Dart", "sample_flutter_app");

            //Removes a Pair from a given key
            langsProjs.Remove("Dart");

            //Number of pairs in the list
            Console.WriteLine("Count: " + langsProjs.Count);

            //Returns wether a key is present
            Console.WriteLine("C# is present: " + langsProjs.ContainsKey("C#"));

            //Gets the value of Java and outputs into a new string called test
            langsProjs.TryGetValue("Java", out string test);
            Console.WriteLine("Java: " + test);

            //Loop over all the pairs in the list
            Console.WriteLine("LOOP:");
            foreach (KeyValuePair<string, string> pair in langsProjs)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            //Empties the dictionary Completely
            langsProjs.Clear();

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region Queue

            //Creates a new Empty Queue
            Queue queue = new Queue();

            //Adds an item to the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            //Loop over a queue
            foreach (object num in queue)
            {
                Console.Write(num + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("is 3 in the queue: " + queue.Contains(3));

            //Removes the first item and return it to you
            Console.WriteLine("Removes 1: " + queue.Dequeue());

            //Returns the first item in the queue without removing it
            Console.WriteLine("Peek the firs num: " + queue.Peek());

            //Empties the queue
            queue.Clear();

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region Stack

            Stack stack = new Stack();

            //Adds an item to the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            //Loop over a stack - items are returned in the opposite order
            foreach (var item in stack)
            {
                Console.WriteLine($"Item: {item}");
            }

            //Returns the last item in the stack without removing it
            Console.WriteLine(stack.Peek());

            //Returns the last item in the stack removing it
            Console.WriteLine(stack.Pop());

            //Returns wether the stack contains an item or not
            Console.WriteLine(stack.Contains(3));

            //Convert to an array and print it with the Join function
            Console.WriteLine(string.Join(", ", stack.ToArray()));

            //Empties the stack
            stack.Clear();

            #endregion

            Console.WriteLine("-------------------------------------------------------");

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


        //GENERICS
        class SimpleMapEntry<TK, TV>
        {
            public TK key { get; set; }
            public TV value { get; set; }

            public SimpleMapEntry(TK key, TV value)
            {
                this.key = key;
                this.value = value;
            }

            public void ShowData()
            {
                Console.WriteLine("{0} is {1}", this.key, this.value);
            }
        }

        //Generic Method
        //allows to perform the same operation on multiple different data types
        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dx = Convert.ToDouble(num1);
            double dy = Convert.ToDouble(num1);
            Console.WriteLine($"{dx} + {dy} = {dx + dy}");
        }

        public struct Rectangle<T>
        {
            public T Width { get; set; }

            public T Height { get; set; }

            public Rectangle(T width, T height)
            {
                Width = width;
                Height = height;
            }

            public string GetArea()
            {
                double width = Convert.ToDouble(Width);
                double height = Convert.ToDouble(Height);
                return string.Format($"{Width} * {Height} = {width * height}");
            }
        }

        //Example Enum
        enum Temperature
        {
            FREEZE,
            LOW,
            WARM,
            HOT,
            SEARING
        }

        //Example Struct
        struct Customer
        {
            private string name;
            private double balance;
            private int id;

            public void createCustomer(string name, double balance, int id)
            {
                this.name = name;
                this.balance = balance;
                this.id = id;
            }

            public void printInfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Balance: " + balance);
                Console.WriteLine("ID: " + id);
            }
        }

        //Example Delegate
        public delegate double EvaluateExpression(double num1, double num2);

    }
}
