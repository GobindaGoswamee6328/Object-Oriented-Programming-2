using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass2
{
    struct AddressFormate
    {
        public int houseno;
        public string roadno;
        public string area;


      public AddressFormate ( int houseno, string roadno, string area )
        {

            this.houseno = houseno;
            this.roadno = roadno;
            this.area = area;

        }

    }

    class Student
    {
        private int id;
        private string name;
        private double cgpa;
        private AddressFormate address;


        public void setid(int id)

        {  
        this.id = id; 
        }
        public int getId()
        {
            return this.id;
        }
        public void setname(string name)

        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setcgpa(double cgpa)

        { 

            this.cgpa = cgpa;
        }
        public double getcgpa()
        {
            return this.cgpa;
        }

        public void setAddress(AddressFormate address)
        {
            this.address = address;
        }

        public AddressFormate getAddress()
        {
            return this.address;
        }

        public void printdata()
        {
            Console.WriteLine(" Student Id : {0}", this.id);
            Console.WriteLine(" Student Name : {0}", this.name);
            Console.WriteLine(" Student Cgpa : {0}", this.cgpa);
            Console.WriteLine(" House NO : {0}", address.houseno);
            Console.WriteLine(" Road No : {0}", address.roadno);
            Console.WriteLine(" Area : {0}", address.area);
            Console.WriteLine();


        }





    }
}
