using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
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
            Console.WriteLine("Date : {0}",this.date);
            Console.WriteLine("Month : {0}", this.month);
            Console.WriteLine("Year : {0}", this.year);


        }



    }



    class Vehicle
    { 
        private int registrationNO;
        private double price;
        private string brand;
        private string colour;
        private DateFormate registrationDate;
        private DateFormate purchaseDate;

        public Double Price

        { 
            set { this.price = value; }
            get { return this.price; }
        }

        public string Brand
         { 
            set { this.brand = value; }
            get { return this.brand; }
        }

        public string Colour
        {
            set { this.colour = value; }
            get { return this.colour; }
        }

       public DateFormate RegistrationDate
        {
            set { this.registrationDate = value; }
            get { return this.registrationDate; }
        }

        public DateFormate PurchaseDate
        {
            set { this.purchaseDate = value;}
            get { return this.purchaseDate; }
        }

        public int RegistrationNo
        {
            set { this.registrationNO = value; }
            get { return this.registrationNO; }
        }

        public Vehicle()
        {

        }

        public Vehicle(int registrationNo,DateFormate registrationdate,double price, string brand,string colour,DateFormate purchaseDate)
        {
            this.RegistrationNo = registrationNO;
            this.RegistrationDate = registrationDate;
            this.Price = price;
            this.Brand = brand;
            this.Colour= colour;
            this.PurchaseDate = purchaseDate;
        }
       

        public void ShowInfo()
        {
            Console.WriteLine("Registration No : {0}", this.RegistrationNo);
            Console.WriteLine("Registration Date :");
            this.RegistrationDate.PrintData();
            Console.WriteLine("Price : {0}", this.Price);
            Console.WriteLine("Brand : {0}", this.Brand);
            Console.WriteLine("Colour : {0}", this.Colour);
            Console.WriteLine("Purchase Date :");
            this.PurchaseDate.PrintData();
            Console.WriteLine();




        }

    }
}
