using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStruct
{
    internal class Program
    {
        struct point
        {
            public int x;
            public int y;

           
            public point(int x,int y)
            {
                this.x = x;
                this.y = y;
            }


            public void PrintPoint() 
            {
                Console.WriteLine(" {0},{1} ", this.x, this.y);
            }
        
        }
        static void Main(string[] args)
        {

            point p1;
            p1.x = 3;
            p1.y = 5;
            p1.PrintPoint();
            
            point p2 = p1;
            p2.x++;
            p2.y--;
            p2.PrintPoint();
            p1.PrintPoint();

           //Another Way To Create Object:

            point p3 = new point();
            p3.x = -9;
            p3.y = 10;
            p3.PrintPoint();


            point p4 = new point(12,-3);
            p4.PrintPoint();
          
            
            
       



        }
    }
}
