using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Product s1 = new Product();
            s1.setid(25);
            s1.setname("Samim");
            s1.setMyDate(new ManufacturingDate(13, 2, 2023));
            s1.setprice(650);
            s1.printdata();

            Product s2 = new Product( 20, "Simanta", new ManufacturingDate(10, 2, 2023),1000);
            s2.printdata();
           

        }
    }
}
