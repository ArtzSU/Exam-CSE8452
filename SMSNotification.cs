namespace ExamProject
{   
    class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}