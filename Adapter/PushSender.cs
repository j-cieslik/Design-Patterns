using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class PushSender : INotyficationSender
    {
        public void SendNotification(int userId, Notification notification)
        {
            Console.WriteLine($"Sending push notification, to: {userId}, Title: {notification.Title}, Body: {notification.Body}");

        }
    }
}