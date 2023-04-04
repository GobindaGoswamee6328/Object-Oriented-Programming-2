using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product s1 = new Product();
            s1.setId(25);
            s1.setName("Samim");
            s1.setMyDate(new DateFormate(13, 2, 2023));
            s1.setPrice(650);
            s1.ShowInfo();

            Product s2 = new Product(20, "Simanta",2000, new DateFormate(10, 2, 2023));
            s2.ShowInfo();

        }
    }
}
