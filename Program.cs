namespace ExamProject
{ 

    interface INotification
    {
        void Send(string message);
    }

    class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }


    class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    class AnotherNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Another Notification sent: {message}");
        }
    }


    class NotificationService
    {
        private readonly INotification _notification;

        public NotificationService(INotification notification)
        {
            _notification = notification;
        }

        public void Notify(string message)
        {
            _notification.Send(message);
        }
    }


    class Program   
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a message to send (or 'exit' to quit):");
                string message = Console.ReadLine();

                if (message.ToLower() == "exit")
                    break;

                Console.WriteLine("Choose notification type (1 for Email, 2 for SMS, 3 for Another):");
                string choice = Console.ReadLine();

                INotification notification;

                if (choice == "1")
                {
                    notification = new EmailNotification();
                }
                else if (choice == "2")
                {
                    notification = new SMSNotification();
                }
                else if (choice == "3")
                {
                
                    notification = new AnotherNotification();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }

                NotificationService service = new NotificationService(notification);
                service.Notify(message);
            }

            
        }
    }
}

