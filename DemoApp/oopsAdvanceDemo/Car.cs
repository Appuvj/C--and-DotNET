using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAdvanceDemo
{
    abstract class Car
    {
        public string brand;
        public string model;

        public abstract string getcardetails();
    }

    class BMW:Car
        {
            public string comfort;

            public override string getcardetails()
            {
                return this.brand + " has release " +this.model+" with the great special feature of "+this.comfort;
            }
        }

        class Fortuner : Car
        {
            public string power;

            public override string getcardetails()
            {
                return this.brand + " has release " + this.model + " with the great special feature of " + this.power;
            }
        }

            

    }

