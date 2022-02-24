using System;
namespace csharp_learning
{
    //? interface ile farkı default parametre vererek zorunlu olarak tek tek methodları doldurmanızı istemez.
    public abstract class Logger
    {
        public abstract void wLog();
        public virtual void rLog()
        {
            Console.WriteLine("Log başarıyla getirildi.");
        }

        public void Log()
        {
            Console.WriteLine("Test logger");
        }
    }
}