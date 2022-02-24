using System;
namespace csharp_learning
{

    //? abstract kalıtım sağlandığında zorunlu olarak implement etmenizi istemez default parametre belirleyebilirsiniz.
    public class NewDatabaseLogger : Logger
    {
        public override void wLog()
        {
            Console.WriteLine("Database logu başarıyla kaydedildi.");
        }

        public override void rLog()
        {
            Console.WriteLine("Database logu başarıyla getirildi.");
        }
    }
}