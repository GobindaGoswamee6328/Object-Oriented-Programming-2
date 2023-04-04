using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMid
{

    struct ProgrammerInfo
    {
        public string skilloflanguage;
        public string developmenttype;

        public ProgrammerInfo(string skilloflanguage,string developmenttype)
        {
          this.skilloflanguage = skilloflanguage;
          this.developmenttype= developmenttype;
        }

        public void Print()
        { 
           Console.WriteLine(" Skill of Language : {0}", this.skilloflanguage);
           Console.WriteLine(" Development Type : {0}", this.developmenttype);
        }

    }


    class Programmer : Engineering
    {
       private ProgrammerInfo info;


        public ProgrammerInfo Info
        {
            set { this.info = value; }
            get { return this.info; }
        }


        public override void ShowInfo()
        {
            base.ShowInfo();
            info.Print();

        }



    }
}
