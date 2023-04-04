using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    class Person
    {

        private string name;
        private string address;
        private int mobile;


        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public int Mobile
        {
            set { this.mobile = value; }
            get { return this.mobile; }
        }

    }
}
