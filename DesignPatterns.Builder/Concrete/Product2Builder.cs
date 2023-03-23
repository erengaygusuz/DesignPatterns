using DesignPatterns.Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Concrete
{
    internal class Product2Builder : IBuilder
    {
        private Product2 product2;

        public Product2Builder()
        {
            product2 = new Product2();
        }

        public void SetPartA(string color)
        {
            product2.Color = color;
        }

        public void SetPartB(string name)
        {
            product2.Name = name;
        }

        public void SetPartC(int stock)
        {
            product2.Stock = stock;
        }

        public void SetPartD(float price)
        {
            product2.Price = price;
        }

        public Product2 GetProduct()
        {
            return product2;
        }
    }
}
