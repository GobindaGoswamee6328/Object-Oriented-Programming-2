using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceExample
{
    internal class Square : IGeometry
    {
        public void Draw()
        {
            Console.WriteLine("Drawing");
        }

        public void Area()
        {
        }
    }
}
