using System;

namespace csharp_learning
{
    public class lesson_6
    {
        public static void switch_case()
        {
            //? Prim ayları (enum ile switch case kullanımı) 
            Aylar aylar = Aylar.Şubat;
            int _month = DateTime.Now.Month;
            switch (aylar)
            {
                case Aylar.Ocak:
                    Console.WriteLine("Ocak ayındasınız ve prim alıyorsunuz!");
                    break;
                case Aylar.Şubat:
                    Console.WriteLine("Şubat ayındasınız ve prim alıyorsunuz!");
                    break;
                case Aylar.Nisan:
                    Console.WriteLine("Nisan ayındasınız ve prim alıyorsunuz!");
                    break;
                case Aylar.Ağustos:
                    Console.WriteLine("Ağustos ayındasınız ve prim alıyorsunuz!");
                    break;
                default:
                    Console.WriteLine("Bu ay prim almıyorsunuz!");
                    break;
            }
        }
        enum Aylar
        {
            Ocak = 1,
            Şubat,
            Mart,
            Nisan,
            Mayıs,
            Haziran,
            Temmuz,
            Ağustos,
            Eylül,
            Ekim,
            Kasım,
            Aralık
        }
    }
}