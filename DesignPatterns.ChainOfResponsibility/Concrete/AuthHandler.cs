using DesignPatterns.ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Concrete
{
    internal class AuthHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Auth")
            {
                return "Auth Handler is Executed";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
