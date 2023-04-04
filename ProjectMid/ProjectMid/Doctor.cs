using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMid
{
    class Doctor : Employee
    {
        private string doctortitle;
        
        public string DoctorTitle
        {
            set { this.doctortitle = value; }
            get { return this.doctortitle; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" Doctor : {0}", this.doctortitle);
        
        }
            
    }
}
