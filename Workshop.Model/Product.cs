using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Model
{
    public class Product
    {
        public string Name { get; set; }
        private decimal _price;
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public string Code { get; private set; }
        public string FormattedName => $"Precio total: { Price }";

        public Product(string name, decimal price, string code)
        {
            Name = name;
            Price = price;
            Code = code;
        }
    }
}
