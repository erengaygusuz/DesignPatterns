using DesignPatterns.Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Concrete
{
    internal class XmlProviderA : IDataProvider
    {
        private Xml xml;

        public XmlProviderA() 
        {
            xml = new Xml();
            xml.Value = "XML Data";
        }

        public Xml GetData()
        {
            return xml;
        }
    }
}
