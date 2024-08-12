using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IContact
    {
        string email { get; set; }
        long mobile { get; set; }

        void getContactDetails();
    }
}
