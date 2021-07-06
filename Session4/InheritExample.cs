using System;

namespace Session4
{
   public class Base
    {
        public Base (int id)
        {
            Console.WriteLine("Base Constructor -Id = " +id);
        }
        public int Id { get ; set ; }
        public void Print()
        {
            Console.WriteLine("Base Class Print");
        }
    }

    public class Dervived : Base
    {
        public Dervived(int id ) : base(id)
        {
            Console.WriteLine("Derived Constructor");
        }
        public void Print()
        {
            Console.WriteLine("Derived class print");
        }
        // public void GetName()
        // {
        //     base.Print();
        //     Print.Name();
        //     Print();

        // }
        // public void Print()
        // {
        //    Id = 100;
        //     Console.WriteLine("Derived class print");
        // }

    }

    
}