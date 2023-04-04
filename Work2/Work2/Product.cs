using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{

    struct DateFormate
    {
        public int date;
        public int year;
        public int month;


        public DateFormate(int date, int year,int month)
        {

            this.date = date;
            this.year = year;
            this.month = month;
        }

        public void print()
        {
            Console.WriteLine("Date : {0}", this.date);
            Console.WriteLine("Month : {0}", this.month);
            Console.WriteLine("Year : {0}", this.year);

        }
    }

    class Product
    {
        private int id;
        private string name;
        private double price;
        private DateFormate mydate;


        public void setId(int id)
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

        public void setPrice(double price)
        {
            this.price = price;
        }
        public double getPrice()
        {
            return this.price;
        }

        public void setMyDate(DateFormate mydate)
        {
            this.mydate = mydate;
        }
        public DateFormate GetMYDate()
        {
            return this.mydate;
        }


        public Product()
        {

        }


        public Product (int id, string name, double price, DateFormate  mydate)
        {
            this.setId(id);
            this.setName(name);
            this.setMyDate(mydate);
            this.setPrice(price);
    
        }


        public void ShowInfo()
        {
            Console.WriteLine("Product Id : {0}", this.id);
            Console.WriteLine("Customer Name : {0}", this.name);
            Console.WriteLine("Product Price : {0}", this.price);
            mydate.print();
            Console.WriteLine();


        }
    }
}
