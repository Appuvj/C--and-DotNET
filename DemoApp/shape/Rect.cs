using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Rect : IShape
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public int side { get; set; }

        public Rect(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public int area()
        {
            return length*breadth;
        }

        public void formula()
        {
            
            Console.WriteLine("area of rectangle: " + area());
        }
    }
}
