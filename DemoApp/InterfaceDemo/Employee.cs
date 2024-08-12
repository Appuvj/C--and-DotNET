using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Employee : IAddress, IContact
    {
        public string name {  get; set; }
        public string addressline1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string email { get; set; }
        public long mobile { get; set; }

        public void addressDetails()
        {
            Console.WriteLine("Employee Address");
            string empAddress=this.name+","+this.addressline1+","
                + this.city+","+this.state+","+this.postcode+",";
            Console.WriteLine(empAddress);
        }

        public void getContactDetails()
        {
            Console.WriteLine("Employee Contact Details");
            string empContact = this.mobile + "," + this.email;
            Console.WriteLine(empContact);
        }
    }
}
