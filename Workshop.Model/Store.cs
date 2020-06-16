using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Model
{
    public class Store : IStore
    {
        private IList<Product> _products;

        public Store()
        {
            _products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void AddProduct(string name, decimal price, string code)
        {
            AddProduct(new Product(name, price, code));
        }

        public Product FindCheapesProduct()
        {
            Product resultado = null;

            foreach(var product in _products)
            {
                if (resultado == null || product.Price < resultado.Price)
                {
                    resultado = product;
                }
            }

            return resultado;
        }

        public void ShowProducts()
        {
            foreach(var product in _products)
            {
                Console.WriteLine("Product: " + product.Name);
                Console.WriteLine("Product: " + product.Price);
                Console.WriteLine("Product: " + product.Code);
            }
            
        }
    }
}
