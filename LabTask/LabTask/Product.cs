using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LabTask

{ 
     struct ManufacturingDate
     {
       private int date;
       private int month;
       private int year;

    public ManufacturingDate(int date, int month, int year)
    {

        this.date = date;
        this.month = month;
        this.year = year;

    }
     public void print()
    {

        Console.WriteLine("Date : {0}", this.date);
        Console.WriteLine("Month : {0}", this.month);
        Console.WriteLine("year : {0}", this.year);


    }




}
  
   

     class Product
    {
        private int id;
        private string name;
        private double price;
        private ManufacturingDate mydate;
        


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

        public void setprice(double price)

        {
            this.price = price;
        }

        public double getprice()
            
        {
            return this.price;

        }

     public void setMyDate(ManufacturingDate mydate)
     {
        this.mydate = mydate;
     }

    public ManufacturingDate getMydate()
     {
        return this.mydate;
     }

        public Product()
        { 
        
        }

        public Product(int id, string name, ManufacturingDate mydate,double price)
        {

            this.setid(id);
            this.setname(name);
            this.setMyDate(mydate);
            this.setprice(price);

        }



    public void printdata()
    {
        Console.WriteLine(" Product Id : {0}", this.id);
        Console.WriteLine(" Product Name : {0}", this.name);
        mydate.print();
        Console.WriteLine(" Product Price : {0}", this.price);
        Console.WriteLine();

    }

}
}
