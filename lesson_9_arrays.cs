namespace csharp_learning
{
    public class lesson_9
    {
        public static void arrays()
        {
            string[] _colors = new string[10];
            string[] _animals = { "dog", "cat", "mouse", "dinasour", "lion" };

            int[] _numbers;
            _numbers = new int[3];
            int[] _numbers2 = { 1, 2, 3, 4, 5, 6 };

            //? Add item to arrays
            _colors[0] = "blue";
            System.Console.WriteLine(_colors[0]);

            //? loops for arrays
            //? example
            System.Console.Write("Dizi uzunluğu giriniz: ");
            int _arrayLength = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < _arrayLength; i++)
            {
                System.Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                _numbers[i] = int.Parse(System.Console.ReadLine());
            }
            int _toplam = 0;
            foreach (var item in _numbers)
            {
                _toplam += item;
            }
            //? example 2
            //? for
            for (int i = 0; i < _colors.Length; i++)
            {
                System.Console.WriteLine(_colors[i]);
            }
            //? foreach
            foreach (var item in _animals)
            {
                System.Console.WriteLine(item);
            }
            //? while
            int _sayac = 0;
            while (_numbers2.Length > _sayac)
            {
                System.Console.WriteLine(_numbers2[_sayac]);
                _sayac++;
            }
        }
    }
}