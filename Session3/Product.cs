using System;

namespace Session3
{
    public class Product
    {
        public int Id { get ; set ;}

        public static string Name {get ; set ;}

        public int Price { get ; set ;}

        public Product()
        {
            Console.WriteLine("I am in default constructor");
        }
        public Product(Product prod)  // copy constrctor
        {
            this.Id = prod.Id;
            this.Price = prod.Price;
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
    
    
}