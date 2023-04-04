using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass2
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Student s1= new Student();
            s1.setid(25);
            s1.setname("Samim");
            s1.setcgpa(3.45);

          //  AddressFormate a1 = new AddressFormate(32,"20","Khulna");
            s1.setAddress(new AddressFormate(32, "20", "Khulna"));
            s1.printdata();
            
           

            Teacher s2 = new Teacher();
            s2.setid(42);
            s2.setname("Hasib");
            s2.setage(32);
            s2.setdepartment("CSE");
            s2.setaddress(new addressformate(46, "Munshiganj", "Bangladesh"));
            s2.printdata();



        }
    }
}
