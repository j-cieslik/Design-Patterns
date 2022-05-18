using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class AuthorizationHandler : BaseHandler
    {
        private Dictionary<int, int> entityOwners = new Dictionary<int, int>()
        {
            { 100, 13 },
            { 101, 14 },
        };


        public AuthorizationHandler(IHandler next) : base(next)
        {

        }

        public override void Handle(RequestContext requestContext)
        {
            if (requestContext.Request.UserRole == "Admin")
            {
                _next.Handle(requestContext);
                return;
            }

            if (entityOwners.TryGetValue(requestContext.Request.EntityId, out int ownerId))
            {
                if (ownerId == requestContext.Request.UserId)
                {
                    _next.Handle(requestContext);
                    return;
                }
            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "User is not authorized";
        }
    }
}