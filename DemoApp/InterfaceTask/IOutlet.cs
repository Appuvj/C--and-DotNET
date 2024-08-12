using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface IOutlet
    {
        string outName { get; set; }
        string city { get; set; }
        string location { get; set; }

        void getOutletDetails();
    }
}
