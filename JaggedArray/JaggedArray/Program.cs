using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
     class Program
    {
        static void Main(string[] args)
        {
            int[][] jx = new int[4][];

            jx[0] = new int[3] {1,2,3};
            jx[1] = new int[2] {4,5};
            jx[2] = new int[5] {6,7,8,9,10};
            jx[3] = new int[1] {11};

            byte r = 0,c;
            while(r < 4)
            {
                c = 0;
                while (c < jx[r].Length) 
                {
                    Console.Write("{0}", jx [r][c]);
                    c++;

                }
                Console.WriteLine();
                r++;
            }



        }
    }
}
