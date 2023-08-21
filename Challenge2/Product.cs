using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Product
    {
        public string Name;
        public string Category;
        public int Price;
        public int Stock;
        public int MinStock;
        public Product(string Name,string Category,int Price,int Stock,int MinStock)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
            this.Stock = Stock;
            this.MinStock = MinStock;
        }
    }
}
