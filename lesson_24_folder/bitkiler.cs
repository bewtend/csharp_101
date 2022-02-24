using System;
namespace csharp_learning
{
    public class Plants : Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapabilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir!");
        }
    }

    public class Tohumlu : Plants
    {
        public Tohumlu()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ureme()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }
    public class Tohumsuz : Plants
    {
        public Tohumsuz()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();

        }
        public void Ureme()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}