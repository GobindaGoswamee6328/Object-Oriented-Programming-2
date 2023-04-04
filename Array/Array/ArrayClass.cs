using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ArrayClass
    {
        //1d Array:

        public void OneDArray()
        {
            int[] Array1 = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine("1D Array is : ");

            int a = 0;

            while (a < Array1.Length)

            {

                Console.Write(Array1[a] + " ");
                a++;

            }
            Console.WriteLine("\n");
        }


        //2D Array:

        public void TwoDArray()
        {

            int[,] Array2 = new int[3, 3] { { 25, 30, 27 }, { 35, 40, 32 }, { 45, 60, 50 } };

            Console.WriteLine("2D Array is : ");
            int a = 0, b;
            while (a < 3)
            {
                b = 0;
                while (b < 3)
                {
                    Console.Write("{0}", Array2[a, b] + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
            Console.WriteLine();

        }

    //Jagged Array:

    public void JaggedArray()
    {
        int[][] Array3 = new int[4][];

        Array3[0] = new int[3] { 1, 2, 3 };
        Array3[1] = new int[2] { 4, 5 };
        Array3[2] = new int[5] { 6, 7, 8, 9, 10 };
        Array3[3] = new int[1] { 11 };

        Console.WriteLine("Jagged Array is : ");

        byte r = 0, c;
        while (r < 4)
        {
            c = 0;
          
            while (c < Array3[r].Length)
            {
                Console.Write("{0}", Array3[r][c] + " ");
                c++;

            }
            Console.WriteLine();
            r++;
        }
    }

    }
}




     
    
