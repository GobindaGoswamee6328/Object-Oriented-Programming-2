using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceExampleD
{
    internal class Student : Person
    {
        private double cgpa;

        private double Cgpa
        {
            get { return this.cgpa; }
            set
            {
                if (value >= 0 && value <= 4)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }
        }

        internal override string Id
        {
            set { this.id = "P-" + value + "-S"; }
        }

        internal Student(string name, AddressFormat address, string bloodGroup, double cgpa) : base(name, address, bloodGroup)
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
