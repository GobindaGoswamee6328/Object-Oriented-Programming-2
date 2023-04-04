using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ProjectMid
{

    struct DateofBirth
    {

        public int date;
        public int month;
        public int year;


        public DateofBirth(int date, int month, int year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }

        public void Print()
        {
            Console.WriteLine(" Date : {0}", this.date);
            Console.WriteLine(" Month : {0}", this.month);
            Console.WriteLine(" Year : {0}", this.year);
        }
    }

    struct  AddressFormate
        {
          public int houseno;
          public int roadno;
          public string city; 
          public string country;

        public AddressFormate(int houseno,int roadno,string city,string country)
        {

            this.houseno = houseno;
            this.roadno = roadno;
            this.city = city;
            this.country = country;
        }
         
        public void Show()
        {
            Console.WriteLine(" House No : {0}", this.houseno);
            Console.WriteLine(" Road No : {0}", this.roadno);
            Console.WriteLine(" City : {0}", this.city);
            Console.WriteLine(" Country : {0}", this.country);

        }

}


    class Person
    {
        private string name;
        private int age;
        private string profession;
        private DateofBirth mydate;
        private AddressFormate address;



        public string Name
        {
            set {this.name = value; }
            get { return name; }
        }

        public int Age
        {
            set { this.age = value; }
            get { return age; }
        }

        public string Profession
        {
            set { this.profession = value; }
            get { return profession; }
        }

        public DateofBirth MyDate
        {

            set { this.mydate = value; }
            get { return mydate; }
        }

        public AddressFormate Address
        {
            set { this.address = value; }
            get { return address; }
        
        }


        public  virtual void ShowInfo()
        {

            Console.WriteLine(" Person Name : {0}", this.name);
            Console.WriteLine(" Person Age : {0}", this.age);
            Console.WriteLine(" Person Profession : {0}", this.profession);
            mydate.Print();
            address.Show();
            Console.WriteLine();


        }
    }
}
