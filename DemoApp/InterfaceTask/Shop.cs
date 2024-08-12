using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    class Shop : IProduct, IOutlet
    {
        public string outName { get; set; }
        public string proName { get; set; }
        public string price { get; set; }
        public string category { get; set; }
        public string city { get; set; }
        public string location { get; set; }

        public void getOutletDetails()
        {
            Console.WriteLine("Outlet Details");
            string outlet=this.outName+"\n"+this.city+"\n"+this.location;
            Console.WriteLine(outlet);
        }

        public void getProductDetails()
        {
            Console.WriteLine("Product Details");
            string product=this.proName+"\n"+this.price+"\n"+this.category;
            Console.WriteLine(product);
        }
    }
}
