using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Abstract
{
    internal abstract class BaseHandler : IHandler
    {
        private IHandler handler;

        public virtual object Handle(object request)
        {
            if (handler != null)
            {
                return handler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this.handler = handler;

            return this;
        }
    }
}
