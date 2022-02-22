using System;

namespace csharp_learning
{
    public class lesson_15
    {
        public static void dateTime_math_methods()
        {
            Console.WriteLine(DateTime.Now); //? Anlık tarihi ve zamanı gösterir.
            Console.WriteLine(DateTime.Now.Date); //? Anlık tarihi gösterir. Zamanı sabit tutar.
            Console.WriteLine(DateTime.Now.Day); //? Anlık günü gösterir 
            Console.WriteLine(DateTime.Now.Month); //? Anlık ayı gösterir
            Console.WriteLine(DateTime.Now.Year); //? Anlık yılı gösterir.
            Console.WriteLine(DateTime.Now.Hour); //? Anlık saati gösterir. 
            Console.WriteLine(DateTime.Now.Minute); //? Anlık dakikayı gösterir.
            Console.WriteLine(DateTime.Now.Second); //? Anlık saniyeyi gösterir.
            Console.WriteLine(DateTime.Now.DayOfWeek); //? Anlık haftanın anlık gününü yazdırır 
            Console.WriteLine(DateTime.Now.DayOfYear); //? Anlık yılın kaçıncı günündesin.
            Console.WriteLine(DateTime.Now.ToLongDateString()); //? Gün ve Ay String geri kalanı ise number olarak gelir.
            Console.WriteLine(DateTime.Now.ToShortDateString()); //? Short tarih ve sadece number gelir.
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //? Saniyesine kadar gösterir
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //? Saniyeyi göstermez
            Console.WriteLine(DateTime.Now.AddDays(1)); //? Gün ekler
            Console.WriteLine(DateTime.Now.AddHours(1)); //? Saat ekler
            Console.WriteLine(DateTime.Now.AddMinutes(1)); //? Dakika ekler
            Console.WriteLine(DateTime.Now.AddSeconds(1)); //? Saniye ekler
            Console.WriteLine(DateTime.Now.AddMonths(1)); //? Ay Ekler
            Console.WriteLine(DateTime.Now.AddYears(1)); //? Yıl ekler

            Console.WriteLine(DateTime.Now.ToString("dd")); //?     dd (tr-TR) → 15
            Console.WriteLine(DateTime.Now.ToString("ddd")); //?    ddd (tr-TR) → Pzt
            Console.WriteLine(DateTime.Now.ToString("dddd")); //?   dddd (tr-TR) → Pazartesi

            Console.WriteLine(DateTime.Now.ToString("MM")); //?     MM (tr-TR) → 06
            Console.WriteLine(DateTime.Now.ToString("MMM")); //?    MMM (tr-TR) → Haz
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //?   MMMM (tr-TR) → Haziran

            Console.WriteLine(DateTime.Now.ToString("yy")); //?     yy (tr-TR) → 09
            Console.WriteLine(DateTime.Now.ToString("yyy")); //?    yyy (tr-TR) → 2009
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //?   yyyy (tr-TR) → 2009



            //? Math
            Console.WriteLine(Math.Abs(-12)); //? negatif sayıyı pozitif yapar
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            Console.WriteLine(Math.Ceiling(1.4)); //? Yukarı yuvarlar
            Console.WriteLine(Math.Round(1.4)); //? Yakın olana yuvarlar
            Console.WriteLine(Math.Floor(1.4)); //? Alta yuvarlar
            Console.WriteLine(Math.Max(1, 6)); //? max alır
            Console.WriteLine(Math.Min(1, 6)); //? min alır
            Console.WriteLine(Math.Pow(2, 4)); //? üslü işlem yapar
            Console.WriteLine(Math.Sqrt(20)); //? karekök alır
            Console.WriteLine(Math.Log(9)); //? 9 un e karşılığı logunu alır
            Console.WriteLine(Math.Log10(10)); //? log10 tabanında 10 u verir
            Console.WriteLine(Math.Exp(3)); //? e üzeri 3 verir

        }
    }
}