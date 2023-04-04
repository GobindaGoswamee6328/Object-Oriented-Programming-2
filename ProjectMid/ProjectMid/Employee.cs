using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMid
{
    class Employee : Person 
    {

        private int employeeid;
        private double salary;

        public int Employeeid
        {
            set { this.employeeid = value; }
            get { return this.employeeid; }
        }


        public double Salary
        {
            set { this.salary = value; }
            get { return this.salary; }
        }


        public  override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" Employee Id : {0} ", this.employeeid);
            Console.WriteLine(" Salary : {0}", this.salary);

        }
    }
}
