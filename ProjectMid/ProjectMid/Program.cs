using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMid
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Jack";
            p1.Age = 35;
            p1.Profession = "Teacher";
            p1.MyDate = (new DateofBirth(10, 4, 1982));
            p1.Address = (new AddressFormate(12, 10, "Dhaka", "Bangladesh"));
            p1.ShowInfo();
           
            
            Employee e1 = new Employee();
            e1.Name = "JOy";
            e1.Age = 22;
            e1.Profession = "Student";
            e1.MyDate = (new DateofBirth(10, 6, 1999));
            e1.Address = (new AddressFormate(12, 10, "Dhaka", "Bangladesh"));
            e1.Employeeid = 1;
            e1.Salary = 10;
            e1.ShowInfo();

            Engineering e2 = new Engineering();
            e2.Name = "Tom";
            e2.Age = 20;
            e2.Profession = "Student";
            e2.MyDate = (new DateofBirth(01, 2, 2001));
            e2.Address = (new AddressFormate(12, 10, "Dhaka", "Bangladesh"));
            e2.Employeeid = 2;
            e2.Salary = 12;
            e2.Rating = 7.8;
            e2.Core = 4.5;
            e2.ShowInfo();


            Programmer p2 = new Programmer();
            p2.Name = "Tom";
            p2.Age = 20;
            p2.Profession = "Student";
            p2.MyDate = (new DateofBirth(01, 2, 2001));
            e2.Address = (new AddressFormate(12, 10, "Dhaka", "Bangladesh"));
            p2.Employeeid = 2;
            p2.Salary = 12;
            p2.Rating = 7.8;
            p2.Core = 4.5;
            p2.Info = (new ProgrammerInfo("Best Programmer", "High"));
            p2.ShowInfo();

            Doctor d1 = new Doctor();
            d1.Name = "JOy";
            d1.Age = 22;
            d1.Profession = "Student";
            d1.MyDate = (new DateofBirth(10, 6, 1999));
            d1.Address = (new AddressFormate(12, 10, "Dhaka", "Bangladesh"));
            d1.Employeeid = 1;
            d1.Salary = 10;
            d1.DoctorTitle = (" Heart Specialist ");
            d1.ShowInfo();

            Student s1 = new Student();
            s1.Name = "Jack";
            s1.Age = 35;
            s1.Profession = "Teacher";
            s1.MyDate = (new DateofBirth(10, 4, 1982));
            s1.Address = (new AddressFormate(12, 10, "Dhaka", "Bangladesh"));
            s1.Subject = " MaTh ";
            s1.Cgpa = 2.94;
            s1.ShowInfo();







        }
    }
}
