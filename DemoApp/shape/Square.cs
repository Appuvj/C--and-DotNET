using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Square : IShape
    {
        public int length { get ; set ; }
        public int breadth { get ; set ; }
        public int side { get ; set ; }


        public Square(int side)
        {
            this.side = side;
        }

        public int area()
        {
            return side * side;
        }

        public void formula()
        {
            
            Console.WriteLine("area of square : "+area());
        }
    }
}
