using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
     class Program
    {
        static void Main(string[] args)
        {
            Vehicle V1 = new Vehicle();
            V1.RegistrationNo = 10;
            V1.RegistrationDate = new DateFormate(12,01,2022);
            V1.Price = 67900;
            V1.Brand = "Yamaha";
            V1.Colour = "Red";
            V1.PurchaseDate = new DateFormate(30,03,2023);
            V1.ShowInfo();

            Vehicle v2 = new Vehicle(12, new DateFormate(22, 01, 2022),45600,"Rang Rover","Blue", new DateFormate(4, 11, 2022));
            v2.ShowInfo();
        }
    }
}
