using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssendingOrder
{

    struct DateFormate
    {
        public int date;
        public int month;
        public int year;

        public DateFormate(int date, int month, int year)
        {

            this.date = date;
            this.month = month;
            this.year = year;
        }

        public void PrintData()
        {
            Console.WriteLine(" Date : {0}", this.date);
            Console.WriteLine(" Month : {0}", this.month);
            Console.WriteLine(" Year : {0}", this.year);

        }

    }

    class Person
    {
        private int id;
        private string name;
        private DateFormate dateOfBirth;



        public int Id
        {
            set { this.id = value; }
            get { return this.id; }

        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public DateFormate DateOfBirth
        {
            set { this.dateOfBirth = value; }
            get { return this.dateOfBirth; }
        }

        public Person()
        {

        }

        public Person(int id, string name, DateFormate dateOfBirth)
        {
            this.Id = id;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }


        public void ShowInfo()
        {
            Console.WriteLine(" Id : {0}", this.id);
            Console.WriteLine(" Name : {0}", this.name);
            Console.WriteLine("Date Of Birth : ");
            this.dateOfBirth.PrintData();
            Console.WriteLine();

        }

    }
    
}
