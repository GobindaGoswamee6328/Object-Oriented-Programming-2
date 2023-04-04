using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;

            do

            {

                Console.Write(" Enter The Number 1 : ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Enter The Number 2 : ");
                int number2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("1. Sum ");
                Console.WriteLine("2. Sub ");
                Console.WriteLine("3. Mul ");
                Console.WriteLine("4. Exit ");

                Console.Write("Enter The Option : ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)

                {
                    Console.Write("Sumation");
                    double sum = number1 + number2;
                    Console.WriteLine(number1 + " + " + number2 + " : " + sum);
                    Console.ReadLine();
                }
                else if (option == 2)

                {
                    Console.Write("Substraction");
                    double sub = number1 - number2;
                    Console.WriteLine(number1 + " - " + number2 + " : " + sub);
                    Console.ReadLine();

                }
                else if (option == 3)
                {

                    Console.Write("Multiplication");
                    double mul = number1 * number2;
                    Console.WriteLine(number1 + " * " + number2 + " : " + mul);
                    Console.ReadLine();

                }

                else if (option == 4)

                {
                    Console.Write("Exit");
                    break;

                }






            } while (flag = true);




        }
    }
}
