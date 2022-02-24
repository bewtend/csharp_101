using System;
namespace csharp_learning
{
    public class SmsLogger : ILogger
    {
        public void rLog()
        {
            Console.WriteLine("Sms logları ekrana getirildi");
            // throw new System.NotImplementedException();
        }

        public void wLog()
        {
            Console.WriteLine("Sms logu kaydedildi.");
            // throw new System.NotImplementedException();
        }
    }
}