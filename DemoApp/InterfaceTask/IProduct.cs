using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface IProduct
    {
        string proName { get; set; }
        string price { get; set; }
        string category { get; set; }

        void getProductDetails();
    }
}
