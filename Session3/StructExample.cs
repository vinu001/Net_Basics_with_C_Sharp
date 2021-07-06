using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
        public struct StructExample
        {
            public int Identity {get ; set ;}

            public StructExample(int _id)
            {
                Identity = _id;
                 Console.WriteLine("I am in Constructor");
            }

            public void PrintName (string name)
            {
                Console.WriteLine(name);
            }
        }
    
}

