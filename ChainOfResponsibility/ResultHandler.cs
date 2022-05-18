using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next) : base(next)
        {

        }

        public override void Handle(RequestContext requestContext)
        {
            requestContext.Response.IsSuccessful = true;
            requestContext.Response.Data = "some value";
        }
    }
}