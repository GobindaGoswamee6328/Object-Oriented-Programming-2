using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceExample
{
    internal class Triangle : IGeometry, IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing");
        }

        void IGeometry.Area() 
        {
        }

        void IShape.Area()
        {
        }

        public void M()
        {
        }
    }
}
