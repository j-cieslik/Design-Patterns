using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler _next;

        public BaseHandler(IHandler next)
        {
            _next = next;
        }

        public abstract void Handle(RequestContext requestContext);
        
    }
}