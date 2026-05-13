namespace ExamProject
{

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
}