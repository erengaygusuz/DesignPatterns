using DesignPatterns.ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Concrete
{
    internal class CacheHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Cache")
            {
                return "Cache Handler is Executed";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
