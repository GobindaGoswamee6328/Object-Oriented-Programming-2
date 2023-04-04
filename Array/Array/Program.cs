using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass a1 = new ArrayClass();
            a1.OneDArray();
            a1.TwoDArray();
            a1.JaggedArray();

            //Directly initialized:
            Console.WriteLine("Directly Init value 1 : {0} ",Constant.b);

            // Call by Method :
            Constant c1 = new Constant();
            c1.Function();


            // Call by Constractor :

            new Constant();

            //Call by method and constructor together:
            Constant c2 = new Constant();
            c1.Function();








        }
    }
}
