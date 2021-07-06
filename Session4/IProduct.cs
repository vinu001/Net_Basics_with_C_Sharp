using System;

namespace Session4
{
    internal interface IProduct
    {
        int Id { get ; set ;}

        string Name { get ; set ;}

        void PrintName();
    }

    internal interface Ishape
    {
        void GetShape();
    }
    internal class Product : IProduct , Ishape
    {
            public int Id { get ; set ;}
            public string Name { get ; set ;}

            public Product()
            {
                Id = 12 ;
                Name = "chair" ;
            }
            public void PrintName()
            {
                Console.WriteLine ("Product Name = " + Name );
            }
            public void GetShape()
            {
                Console.WriteLine("Get shape method of product");
            }
    }
    
        
}