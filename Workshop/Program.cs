using System;
using Workshop.Model;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var productOne = new Product() 
            { 
                Name = "Monitor de 17 pulgadas",
                Price = 200,
                Code = "M1710"
            };*/

            Product productOne = new Product("Monitor de 17 pulgadas", 200, "M1710");

            IStore store = new Store();
            store.AddProduct(productOne);
            store.AddProduct("Mouse Wireless", 30, "MW99");
            store.ShowProducts();

            Console.WriteLine("El producto mas barato es: " + store.FindCheapesProduct().Name);

            Console.WriteLine(productOne.FormattedName);
        }
    }
}
