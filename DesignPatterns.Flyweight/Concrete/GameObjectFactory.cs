using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight.Concrete
{
    internal class GameObjectFactory
    {
        private GameObject gameObject;

        public GameObject GetObject(string color, string model) 
        { 
            if (gameObject == null)
            {
                gameObject = new GameObject(color, model);
                Thread.Sleep(1000);
            }

            return gameObject; 
        }

    }
}
