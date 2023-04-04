using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    class Customer : Person
    {
        private int customernmbr;
        private bool mailingpermission;


        public int CustomerNmbr
        {
            set { this.customernmbr = value; }
            get { return this.customernmbr; }
        }

        public bool MailingPermission
        {
            set { this.mailingpermission = value;}
            get { return this.mailingpermission;} 
        }

    }
}
