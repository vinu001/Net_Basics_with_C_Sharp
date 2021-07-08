using System;

namespace Session5
{
    public class Delegate
    {
    public delegate void PrintDelegate(string arg);
        public PrintDelegate printDel;
        public void Print(string name)
        {
            Console.WriteLine("Print function = " + name);
        }

        public void PrintNumber(string num)
        {
            Console.WriteLine("Print Number Function = " + num );
        }
    }
    
}