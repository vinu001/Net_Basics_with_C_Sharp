using System;

namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            //    StructExample structExample = new StructExample();
            //    structExample.PrintName("This is struct");
           
           Product prd = new Product();
        prd.Id = 10;
        prd.Price = 500;
        Console.WriteLine (prd.Id + " " + prd.Price);
   // System.Console.WriteLine("PAram1 = " + args[0]);
     // System.Console.WriteLine("PAram2 = " + args[1]);
           Console.ReadLine();
        }
    }
}
