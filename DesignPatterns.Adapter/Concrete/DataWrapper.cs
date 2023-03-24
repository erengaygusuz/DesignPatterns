using DesignPatterns.Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Concrete
{
    internal class DataWrapper : IDataProvider
    {
        private JsonProvider jsonProvider;

        public DataWrapper() 
        { 
            jsonProvider = new JsonProvider();
        }

        public Xml GetData()
        {
            return ConvertJsonDataToXml(jsonProvider.GetData());
        }

        private Xml ConvertJsonDataToXml(Json data)
        {
            return new Xml
            {
                Value = data.Value
            };
        }
    }
}
