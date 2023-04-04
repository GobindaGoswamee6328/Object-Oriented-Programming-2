using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMid
{
    class Student : Person
    {

        private string subject;
        private double cgpa;


        public string Subject
        {
            set { this.subject = value; }
            get { return this.subject; }
        }

        public double Cgpa
        {
            set { this.cgpa = value; }
            get { return this.cgpa; }
        }

     
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" Subject Name : {0}", this.subject);
            Console.WriteLine(" Student Cgpa : {0}",this.cgpa);
        }
    }
}
