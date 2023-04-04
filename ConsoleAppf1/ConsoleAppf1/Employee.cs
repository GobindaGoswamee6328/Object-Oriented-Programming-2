using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppf1
{
    internal class Employee : Person
    {
        private double salary;

        internal double Salary
        {

            set
            {
            if (value >= 0)
              this.salary = value;

                    else
                        this.salary = -2;
            }

            get { return this.salary; }
        }

        internal Employee(int id, string name, string bloodgroup, AddressFormate address,double salary) : base(id, name, bloodgroup, address) 
        {
            this.salary = salary;

        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" Salary : {0}", this.Salary);
        }


    }
}
