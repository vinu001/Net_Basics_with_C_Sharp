using System;

namespace Session7
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

          //  calculate.addSubDelegate = calculate.Add;
            calculate.addSubDelegate += calculate.Sub;

            calculate.addSubDelegate(150, 50);
        }
    }
}
