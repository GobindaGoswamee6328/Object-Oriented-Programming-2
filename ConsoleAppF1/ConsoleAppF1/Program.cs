using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppF1
{
 
    class Program
    {
            static void Main(string[] args)
            {
                Person[] people = new Person[3];
                people[0] = new Person(100, "Bruce", new AddressFormat(23, 66, 1230, "Khulna"), "O+");
                people[1] = new Student(200, "Clerk", new AddressFormat(27, 12, 1900, "Sylhet"), "B+", 3.61);
                people[2] = new Employee(300, "Diana", new AddressFormat(87, 11, 2304, "Bogura"), "AB+", 19000);

                foreach (Person p in people)
                {
                    p.ShowInfo();
                    Console.WriteLine();
                }
                //Console.ReadLine();
            }
    }
    
}
