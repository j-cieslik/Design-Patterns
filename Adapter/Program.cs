using Adapter;

INotyficationSender notyficationSender = new EmailSender();
notyficationSender.SendNotification(1, new Notification() { Title = "Test", Body = "Body" });

INotyficationSender notyficationSenderSMS = new SmsSenderAdapter();
notyficationSenderSMS.SendNotification(1, new Notification() { Title = "Test", Body = "Body" });

