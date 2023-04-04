using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppf1
{
    internal struct AddressFormate
    {
        private byte houseno;
        private byte roadno;
        private ushort postalcode;
        private string district;


        public AddressFormate(byte houseno,byte roadno, ushort postalcode, string district)
        {
            this.houseno = houseno;
            this.roadno = roadno;
            this.postalcode = postalcode;
            this.district = district;
        }


        public void PrintInfo()
        {
            Console.WriteLine(" House Nmbr : {0}", this.houseno);
            Console.WriteLine("Road No: {0}", this.roadno);
            Console.WriteLine("Postal Code: {0}", this.postalcode);
            Console.WriteLine("District: {0}", this.district);

        }

    }


    internal class Person
    {
        private int id;
        private string name;
        private string bloodgroup;
        private AddressFormate address;


        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        internal string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        internal string BloodGroup
        {
            set { this.bloodgroup = value; }
            get { return this.bloodgroup; }
        }

        internal AddressFormate Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        internal Person(int id, string name, string bloodgroup, AddressFormate address)
        {
            this.Id = id;
            this.Name = name;
            this.BloodGroup = bloodgroup;
            this.Address = address;

        }

        internal virtual void ShowInfo()
        {

            Console.WriteLine(" Id : {0}", this.Id);
            Console.WriteLine(" Name : {0}", this.Name);
            Console.WriteLine(" Blood Group : {0}", this.BloodGroup);
            this.Address.PrintInfo();

        }


    }
}
