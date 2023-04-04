using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    struct AddressFormate
     {   
        public int houseno;
        public int roadno;
        public string area;

    public AddressFormate (int houseno, int roadno,string area)

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
        private AddressFormate formate;


        public void setId (int id)
        {
            this.id = id;
        }
        public int getId()
        { 
            return this.id;
        }


        public void setName(string name)
        {
            this.name = name;        
        }
        public string getName()
        {
            return this.name;
        }


        public void setCgpa(double cgpa)
        { 
            this.cgpa = cgpa;
        }
        public double getCgpa()
        {
            return this.cgpa;
        }

        public void setFormate( AddressFormate formate)
        {
            this.formate = formate;
        }
        public AddressFormate GetFormate() 
        {
            return this.formate;
        }


        public void ShowInfo()
        {
            Console.WriteLine(" Student Id: {0}", this.id);
            Console.WriteLine(" Student Name: {0}", this.name);
            Console.WriteLine(" Student Cgpa: {0}", this.cgpa);
            Console.WriteLine(" House No : {0}", formate.houseno);
            Console.WriteLine(" Road No : {0}", formate.roadno);
            Console.WriteLine(" Area : {0}", formate.area);
            Console.WriteLine();


        }


    }
}
