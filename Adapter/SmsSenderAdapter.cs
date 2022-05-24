using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class SmsSenderAdapter : INotyficationSender
    {
        private SmsSender _smsSender = new SmsSender();

        public void SendNotification(int userId, Notification notification)
        {
            string userPhoneNumber = null; //based on userId
            _smsSender.SendSms(userPhoneNumber, $"{ notification.Title } { notification.Body }");
        }
    }
}