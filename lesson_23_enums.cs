using System;
namespace csharp_learning
{
    public class lesson_23
    {
        public static void _enums()
        {
            Console.WriteLine(Days.Pazartesi);
            Console.WriteLine((int)Days.Cuma);
            Console.WriteLine((int)Days.Cumartesi);


            int _temperature = 11;

            if (_temperature >= (int)Weather.Güneşli)
            {
                Console.WriteLine("Hava gayet sıcak!");
            }
            else if (_temperature >= (int)Weather.Yağmurlu)
            {
                Console.WriteLine("Hava çok sıcak değil!");
            }
            else
            {
                Console.WriteLine("Hava soğuk!");
            }
        }
    }

    enum Days
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 6,
        Cumartesi,
        Pazar
    }

    enum Weather
    {
        Güneşli = 25,
        Yağmurlu = 12,
        Karlı = 0,
    }
}