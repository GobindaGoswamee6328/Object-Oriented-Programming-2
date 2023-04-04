using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMid
{
    class Engineering : Employee
    {
        private double rating;
        private double core;

        public double Rating
        {
            set { this.rating = value; }
            get { return this.rating; }

        }

        public double Core
        {
            set { this.core = value; }
            get { return this.core; }
        }

        public override void ShowInfo()
        { 
            base.ShowInfo();
            Console.WriteLine(" Rating : {0} ", this.rating);
            Console.WriteLine(" Core : {0}", this.core);

        }

    }
}
