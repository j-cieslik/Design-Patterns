using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class EmailSender : INotyficationSender
    {
        public void SendNotification(int userId, Notification notification)
        {
            Console.WriteLine($"Sending email notification, to: {userId}, Title: {notification.Title}, Body: {notification.Body}");
        }
    }
}