using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    public class Calculate
    {
        public delegate void AddSubDelegate(double num1, double num2);
        public AddSubDelegate addSubDelegate;
        public void Add (double num1, double num2)
        {
            Console.WriteLine("Addition of two umber is : " + (num1 + num2));
        }
        public void Sub(double num1, double num2)
        {
            Console.WriteLine("Substraction of two umber is : " + (num1 - num2));
        }

       
    }
}
