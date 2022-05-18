using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        void Handle(RequestContext requestContext);
    }
}