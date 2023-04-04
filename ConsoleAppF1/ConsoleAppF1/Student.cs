using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppF1
{
    internal class Student : Person
    {
        private double cgpa;

        internal double Cgpa
        {
            get { return this.cgpa; }
            set
            {
                if (value >= 0 && value <= 4.00)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }
        }

        internal Student(int id, string name, AddressFormat address, string bloodGroup, double cgpa) : base(id, name, address, bloodGroup)
        {
            this.Cgpa = cgpa;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("CGPA: " + this.Cgpa);
        }
    }
}
