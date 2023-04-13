using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceExampleD
{
    internal struct AddressFormat
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string district;

        public AddressFormat(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}", this.district);
        }
    }

    internal abstract class Person
    {
        private static int serialNo = 0;
        private protected string id;
        //private string name;
        //private AddressFormat address;
        //private string bloodGroup;

        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = "P-" + value; }
        }

        internal string Name { get; private set; }

        internal AddressFormat Address { get; set; }

        internal string BloodGroup { get; set; }

        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        //internal AddressFormat Address
        //{
        //    get { return this.address; }
        //    private set { this.address = value; }
        //}

        //public string BloodGroup
        //{
        //    get { return this.bloodGroup; }
        //    set { this.bloodGroup = value; }
        //}

        //internal Person() { }

        internal Person(string name, AddressFormat address, string bloodGroup)
        {
            this.Id = (++serialNo).ToString();
            this.Name = name;
            this.Address = address;
            this.BloodGroup = bloodGroup;
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine("Blood Group: " + this.BloodGroup);
            this.Address.PrintAddress();
        }
        
    }
}
