using System;
namespace csharp_learning
{
    public class FileLogger : ILogger
    {
        public void rLog()
        {
            Console.WriteLine("File logları ekrana getirildi.");
        }

        public void wLog()
        {
            Console.WriteLine("File logu kaydedildi.");
        }
    }
}