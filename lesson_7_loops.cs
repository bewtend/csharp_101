using System;

namespace csharp_learning
{
    public class lesson_7
    {
        public static void loops()
        {
            Console.Write("Bir sayı giriniz:");
            int _input = int.Parse(Console.ReadLine());
            //? for example
            for (int i = 1; i <= _input; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //? for example 2
            int _tek = 0;
            int _cift = 0;
            for (int i = 1; i <= _input; i++)
            {
                if (i % 2 == 0)
                {
                    _cift += i;
                }
                else
                {
                    _tek += i;
                }
            }
            Console.WriteLine("Çift sayılar toplamı: " + _cift);
            Console.WriteLine("Tek sayılar toplamı: " + _tek);

            //? for continue - break
            for (int i = 0; i < _input; i++)
            {
                if (i == 200)
                {
                    Console.WriteLine("256 bit'e yaklaştınız haberiniz olsun!");
                    continue;
                }
                if (i == 256)
                {
                    Console.WriteLine("Bu işlem sadece 256 bit'e kadar destekler.");
                    break;
                }
            }
        }
    }
}