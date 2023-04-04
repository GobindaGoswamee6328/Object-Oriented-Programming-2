using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.setId(12);
            s1.setName("Ashok");
            s1.setCgpa(3.75);
            s1.setFormate(new AddressFormate(12, 20, "Dhaka"));
            s1.ShowInfo();



        }
    }
}
