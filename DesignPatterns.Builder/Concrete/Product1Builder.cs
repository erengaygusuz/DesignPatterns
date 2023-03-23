using DesignPatterns.Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Concrete
{
    internal class Product1Builder : IBuilder
    {
        private Product1 product1;

        public Product1Builder() 
        { 
            product1 = new Product1();
        }

        public void SetPartA(string color)
        {
            product1.Color = color;
        }

        public void SetPartB(string name)
        {
            product1.Name = name;
        }

        public void SetPartC(int stock)
        {
            product1.Stock = stock;
        }

        public void SetPartD(float price)
        {
            product1.Price = price;
        }

        public Product1 GetProduct() 
        {
            return product1; 
        }
    }
}
