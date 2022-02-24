using System;
namespace csharp_learning
{
    public class Animals : Canlilar
    {
        protected void Adaptaston()
        {
            Console.WriteLine("Havyanlar adaptan kurabilir.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Havyanlar temasa tepki verir!");
        }
    }

    public class Surungenler : Animals
    {
        public Surungenler()
        {
            base.Adaptaston();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();

        }
        public void Hareket()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }
    public class Kuslar : Animals
    {
        public Kuslar()
        {
            base.Adaptaston();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();

        }
        public void Hareket()
        {
            Console.WriteLine("Kuşlar genelde uçarak ulaşım sağlarlar fakat yürüyedebilirler");
        }
    }
}