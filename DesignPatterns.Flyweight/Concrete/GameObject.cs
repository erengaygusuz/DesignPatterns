using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight.Concrete
{
    internal class GameObject
    {
        public string Color { get; set; }
        public string Model { get; set; }

        public GameObject(string color, string model) 
        {
            Color = color;
            Model = model;
        }

        public void Move(float speed)
        {
            Console.WriteLine("GameObject speed: " + speed);
        }
    }
}
