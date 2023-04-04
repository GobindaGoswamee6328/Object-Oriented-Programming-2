using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
     class Student
    {
        public int id;
        public string name;
        public double cgpa;

        public Student(int id, string name, double cgpa)
        {

            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
        }

        public void setdata()
        {
            Console.WriteLine("Student Id : {0}", this.id);
            Console.WriteLine("Student Name : {0}", this.name);
            Console.WriteLine("Student Cgpa : {0}", this.cgpa);







        }







    }
}
