using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Model
{
    public interface IStore
    {
        void AddProduct(Product product);
        void AddProduct(string name, decimal price, string code);
        Product FindCheapesProduct();
        public void ShowProducts();
    }
}
