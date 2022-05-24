using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Adapter
{
    public interface INotyficationSender
    {
        void SendNotification(int userId, Notification notification);
    }
}