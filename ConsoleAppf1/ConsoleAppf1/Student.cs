using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppf1
{
    internal class Student : Person
    {
        private double cgpa;
        
        internal double Cgpa
        {
            set 
            {

                if (value >= 0 && value <= 4.00)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }

            get { return this.cgpa; }
        }


        internal Student(int id, string name, string bloodgroup, AddressFormate address, double cgpa) : base(id, name, bloodgroup, address)
        {
            this.cgpa = cgpa;

        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" Cgpa : {0}", this.Cgpa);
        }
    }
}
