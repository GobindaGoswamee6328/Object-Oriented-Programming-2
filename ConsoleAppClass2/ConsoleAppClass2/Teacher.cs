using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass2
{
    struct addressformate
    {
        public int houseno;
        public string zila;
        public string country;
    
        public addressformate ( int houseno,string zila, string country )
        {
            this.houseno = houseno;
            this.zila = zila;
            this.country = country;
        }

    }


    class Teacher
    {
        private int id;
        private string name;
        private int age;
        private string department;
        private addressformate address;


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

        public void setage(int age)
        {
            this.age = age;
        }
        public int getage()
        {
            return this.age;
        }

        public void setdepartment(string department)
        {
            this.department = department;
        }
        public string getdepartment()
        {
            return this.department;
        }

        public void setaddress(addressformate address)
        {
            this.address = address;
        }
        public addressformate getaddress()
        {
            return this.address;
        }


        public void printdata()
        {
            Console.WriteLine(" Teacher Id : {0}", this.id);
            Console.WriteLine(" Teacher Name : {0}", this.name);
            Console.WriteLine(" Teacher Age : {0}", this.age);
            Console.WriteLine(" Teacher Department : {0}", this.department);
            Console.WriteLine(" House No : {0}", address.houseno);
            Console.WriteLine(" Zila : {0}", address.zila);
            Console.WriteLine(" Country : {0}", address.country);


        }

    }
}
