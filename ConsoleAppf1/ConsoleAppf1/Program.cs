using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppf1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] p1 = new Person[3];

            p1[0] = new Person ( 12, "Alok", "A+", new AddressFormate(25, 12, 1900, "Sylhet"));
            p1[1] = new Student( 20, "Joy", "B+",new AddressFormate (27, 08, 1910, "Dhaka"), 3.61);
            p1[2] = new Employee( 25, "Hridoy", "AB+", new AddressFormate(12, 105, 1936, "Chittagong"), 3600);


            foreach (Person p in p1)
            {
                p.ShowInfo();
                Console.WriteLine();
            }





        }
    }
}
