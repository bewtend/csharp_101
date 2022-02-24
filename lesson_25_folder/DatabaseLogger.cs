using System;
namespace csharp_learning
{
    public class DatabaseLogger : ILogger
    {
        public void rLog()
        {
            Console.WriteLine("Database logları getirildi.");
        }

        public void wLog()
        {
            Console.WriteLine("Database logu kaydedildi.");
        }
    }
}