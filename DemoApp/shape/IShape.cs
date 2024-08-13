using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    interface IShape
    {
        int length { get; set; }
        int breadth { get; set; }
        int side { get; set; }

        void formula();

    }
}
