using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Id = 17;
            p1.Name = "Joy";
            p1.DateOfBirth = new DateFormate(12, 02, 2022);
            p1.ShowInfo();

            Person p2 = new Person(25, "Simanta", new DateFormate(22, 5, 2022));
            p2.ShowInfo();

            Person p3 = new Person(42, "Tom", new DateFormate(28, 07, 2022));
            p3.ShowInfo();

        }


           
    }
}
