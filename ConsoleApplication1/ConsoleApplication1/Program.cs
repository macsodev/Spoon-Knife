using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\n\nWorld!");
            Console.WriteLine("Integer: " + 10 + " Double: " + 3.14 + " Boolean: " + true);

            Console.Write("Kiiras új sor nélkül :)");

            // Decimal - a 128 - bits data type, with more precision than other floating - point types,
            // suited for financial and monetary calculations
            decimal fooDecimal = 150.3m;

            // Boolean - true & false
            bool fooBoolean = true; // or false

            // Char - A single 16-bit Unicode character
            char fooChar = 'A';

            // Strings -- unlike the previous base types which are all value types,
            // a string is a reference type. That is, you can set it to null
            string fooString = "\"escape\" quotes and add \n (new lines) and \t (tabs)";
            Console.WriteLine(fooString);


            // Formatting, based on sprintf
            string fooFs = string.Format("Check Check, {0} {1}, {0} {1:0.0}", 1, 2);
            Console.WriteLine(fooFs);

            DateTime fooDate = DateTime.Now;
            Console.WriteLine(fooDate.ToString("yyyy MMMM dd, hh:mm"));

            // You can split a string over two lines with the @ symbol. To escape " use ""
            const string bazString = @"Here's some stuff
on a new line! ""Wow!"", the masses cried";

            Console.WriteLine(bazString);

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            int h = Console.WindowHeight;
            int w = Console.WindowWidth;

            string str = "T-Systems";

            Console.SetCursorPosition((int)w / 2 - (int)(str.Length / 2), (int)h / 2);
            Console.WriteLine("T-Systems\n");

            Console.Read();
            Console.SetWindowSize(w / 2 + 5, h / 2);
            Console.WriteLine("A program argumentumai: ");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args[" + i + "]: " + args[i]);
            }


            // Arrays - zero indexed
            // The array size must be decided upon declaration
            // The format for declaring an array is follows:
            // <datatype>[] <var name> = new <datatype>[<array size>];
            int[] intArray = new int[10];

            // Another way to declare & initialize an array
            int[] y = { 9000, 1000, 1337 };

            // Indexing an array - Accessing an element
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("y[" + i + "]: " + y[i]);
            }
            // Arrays are mutable.
            intArray[1] = 1;


            // Lists
            // Lists are used more frequently than arrays as they are more flexible
            // The format for declaring a list is follows:
            // List<datatype> <var name> = new List<datatype>();
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();
            List<int> z = new List<int> { 9000, 1000, 1337 }; // initialize
            // The <> are for generics - Check out the cool stuff section

            // Lists don't default to a value;
            // A value must be added before accessing the index
            intList.Add(1);
            Console.WriteLine("intList @ 0: " + intList[0]);
            for (int i = 0; i < 10; i++)
            {
                intList.Add(i);
            }
            Console.WriteLine("intList after adding elements: (foreach)");
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            intList.Reverse();
            Console.WriteLine("intList after reversing order of elements:");
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Greatest element of this list: " + intList.Max());


            ConsoleKeyInfo key;

            Console.WriteLine("To exit, press Esc key...");
            do {
                
                key = Console.ReadKey(true);
                
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
