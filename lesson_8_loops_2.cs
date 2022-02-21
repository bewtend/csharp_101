namespace csharp_learning
{
    public class lesson_8
    {
        public static void loops_2()
        {
            //? while example
            System.Console.Write("Bir sayı giriniz: ");
            int _input = int.Parse(System.Console.ReadLine());
            int _sayac = 1;
            int _toplam = 0;
            while (_sayac <= _input)
            {
                _toplam += _sayac;
                _sayac++;
            }
            System.Console.WriteLine((_toplam / _input).ToString());


            //? foreach example
            string[] _cars = { "mercedes", "bmv", "bmc", "reno" };
            foreach (var item in _cars)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}