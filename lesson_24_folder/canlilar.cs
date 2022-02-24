using System;
using csharp_learning;

namespace csharp_learning
{
    //? sealed eklenirse eğer kalıtım alınmasını engeller!
    public class Canlilar : lesson_24
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar bosaltim yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}