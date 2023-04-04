using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    struct userinfo
    {

        public string username;
        public string usergender;
        public string contractnmbr;

        public userinfo(string username, string usergender,string contractnmbr)
        {

            this.username = username;
            this.usergender = usergender;
            this.contractnmbr = contractnmbr;
        }


    }


     class Transport
    {
        private string companyname;
        private string modelname;
        private int engineserial;
        private userinfo user;


        public void setcompanyname(string companyname)
        { 
            this.companyname = companyname; 
        }
        public string getcompanyname()
        {
            return this.companyname;
        }

        public void setmodelname(string modelname)
        {
            this.modelname = modelname;
        }
        public string getmodelname()
        {
            return this.modelname;
        }

        public void setengineserial(int engineserial)
        {
            this.engineserial = engineserial;
        }
        public int getengineserial()
        {
            return this.engineserial;
        }

        public void setuserinfo(userinfo user)
        {
            this.user = user;
        }
        public userinfo getuser()
        {
            return this.user;
        }

        public void showinfo()
        {
            System.Console.WriteLine("\n Company Name; {0}", this.companyname);
            System.Console.WriteLine(" Model Name: {0}", this.modelname);
            System.Console.WriteLine(" Engine Serial: {0}", this.engineserial);
            System.Console.WriteLine(" User Name: {0}", user.username);
            System.Console.WriteLine(" User Gender: {0}", user.usergender);
            System.Console.WriteLine(" User Contract Number: {0}\n", user.contractnmbr);
          


        }


    }




    }

