using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class MathOperation
    {

        private int num1;
        private int num2;

        public MathOperation(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int add()
        {
            return num1 + num2;
        }

        public int subtract()
        {
            return num1 - num2;
        }

        public int multiply()
        {
            return num1 * num2;
        }

        public int divide()
        {
            return num1 / num2;
        }

        public void display()
        {
            Console.WriteLine("addition: " + add());
            Console.WriteLine("subtraction: " + subtract());
            Console.WriteLine("multiplication: " + multiply());
            Console.WriteLine("divide: " + divide());

        }

    }
}
