using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight.Concrete
{
    internal class Context
    {
        private GameObjectFactory gameObjectFactory;
        private List<GameObject> gameObjectList;
        private float speed;

        public Context(string color, string model, float speed)
        {
            gameObjectFactory = new GameObjectFactory();
            gameObjectList = new List<GameObject>();

            this.speed = speed;

            for (int i = 0; i < 50;  i++)
            {
                gameObjectList.Add(gameObjectFactory.GetObject(color, model));
            }
        }

        public void Move()
        {
            gameObjectList.ForEach(x => x.Move(speed += 10));
        }
    }
}
