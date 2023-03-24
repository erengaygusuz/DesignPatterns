using DesignPatterns.Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Concrete
{
    internal class JsonProvider
    {
        private Json json;

        public JsonProvider() 
        { 
            json = new Json();
            json.Value = "Json Data";
        }

        public Json GetData()
        {
            return json;
        }
    }
}
