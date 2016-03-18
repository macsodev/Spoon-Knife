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

            Console.WriteLine("T-Systems\n");
        }
    }
}
