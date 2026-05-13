namespace ExamProject
{
    class AnotherNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Another Notification sent: {message}");
        }
    }
}