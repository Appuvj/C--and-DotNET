using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Company : IAddress, IContact
    {
        public string Name { get; set; }
        public string addressline1 { get ; set ; }
        public string city { get ; set ; }
        public string state { get ; set ; }
        public string postcode { get ; set ; }
        public string email { get ; set ; }
        public long mobile { get ; set ; }

        public void addressDetails()
        {
            Console.WriteLine("Company Address");
            string address=this.Name+","+this.addressline1+","+this.city+","+this.state+","+this.postcode;
            Console.WriteLine(address);
        }

        public void getContactDetails()
        {
            Console.WriteLine("Company Details");
            string details=this.email+","+this.mobile;
            Console.WriteLine(details);
        }
    }
}
