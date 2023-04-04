using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Constant
    {
        public int a = 10;
        public const int b = 20;
        public readonly int c = 30;

        public void Function()
        {
            Console.WriteLine(" Method 1 : {0} ", a);
            Console.WriteLine(" Method 2 : {0} ", b);
            Console.WriteLine(" Method 3 : {0} ", c );

        }

        public Constant()
        
        {
            Console.WriteLine(" Method 1 : {0} ", a);
            Console.WriteLine(" Method 2 : {0} ", b);
            Console.WriteLine(" Method 3 : {0} ", c);

        }



    }
}
