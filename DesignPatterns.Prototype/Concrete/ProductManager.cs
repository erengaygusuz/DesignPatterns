using DesignPatterns.Prototype.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Concrete
{
    internal class ProductManager
    {
        private ProductA productA;
        
        private List<ProductA> products;

        public ProductManager() 
        {
            products = new List<ProductA>();   

            productA = new ProductA();

            productA.Name = "Product A";
            productA.Price = 20;

            products.Add((ProductA)productA.Clone());

            productA.Price = 15;

            products.Add((ProductA)productA.Clone());
        }

        public List<ProductA> GetProducts()
        {
            return products;
        }
    }
}
