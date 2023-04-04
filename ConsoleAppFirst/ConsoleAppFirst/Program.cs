using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to spring semister");
            Console.WriteLine("Welcome to c#");

            int ax = 10, bx = 20, cx = 30;

            Console.WriteLine("ax: " + ax + ", bx: " + bx + ", cx: " + cx);

            // Using Place Holder:
            Console.WriteLine("ax: {0}, bx: {1}, cx: {2}", ax, bx, cx);
            Console.WriteLine("{0}", bx);


            // User Input:
            // Console.ReadLine();


            string s1 = Console.ReadLine();
            Console.WriteLine("Output1: {0}", s1);


            // String to int Convert:
            // string s2 = Console.ReadLine();
            int n1 = Convert.ToInt32(Console.ReadLine());

            // Or

            int n2 = Int32.Parse(Console.ReadLine());

            // Addition and Substraction:
            Console.WriteLine("{0}, {1}", n1 + n2, n1 - n2);

            // For Loop:
            for (int a = 0; a < 4; a++)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();

            // While Loop:
            int b = 0;
            while (b > 4)
            {
                Console.Write("{0} ", b);
                b++;
            }
            Console.WriteLine();

    }   }
}
