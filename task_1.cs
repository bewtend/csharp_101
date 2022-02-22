using System;

namespace csharp_learning
{
    public class task_1
    {
        public static void question1()
        {

            //? Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //? Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Kaç adet sayı gireceksiniz? : ");
            uint _uint = 0;
            try
            {
                _uint = uint.Parse(Console.ReadLine());

            }
            catch (System.Exception)
            {
                Console.WriteLine("Yanlış karakter girdiniz!");
                Console.Write("Tekrar deneyiniz: ");
                _uint = uint.Parse(Console.ReadLine());
            }
            int[] _input = new int[_uint];
            int[] _result = new int[_input.Length];
            for (int i = 0; i < _uint; i++)
            {
                Console.Write("Lütfen bir sayı giriniz: ");
                _input[i] = int.Parse(Console.ReadLine());
                if (_input[i] % 2 == 0)
                {
                    _result[i] = _input[i];
                }
            }
            for (int i = 0; i < _result.Length; i++)
            {
                Console.Write(_result[i] + " ");
            }
        }

        public static void question2()
        {
            //? Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //? Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //? Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            uint _input = 0;
            uint _input2 = 0;
            try
            {
                Console.Write("Kaç adet sayı ile çalışmak istediğinizi giriniz: ");
                _input = uint.Parse(Console.ReadLine());
                Console.Write("Bölecek sayıyı giriniz: ");
                _input2 = uint.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Yanlış karakter giriş yaptınız tekrar deneyiniz!");
                Console.Write("Kaç adet sayı ile çalışmak istediğinizi giriniz: ");
                _input = uint.Parse(Console.ReadLine());
                Console.Write("Bölecek sayıyı giriniz: ");
                _input2 = uint.Parse(Console.ReadLine());
            }
            int[] _arr = new int[_input];
            int[] _result = new int[_input];

            for (int i = 0; i < _input; i++)
            {
                Console.Write("Lütfen bir sayı giriniz: ");
                _arr[i] = int.Parse(Console.ReadLine());
                if (_input2 == _arr[i] || _arr[i] % _input2 == 0)
                {
                    _result[i] = _arr[i];
                }

            }
            foreach (var item in _result)
            {
                Console.Write(item + " ");
            }
        }
        public static void question3()
        {
            //? Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //? Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            uint _input = 0;
            try
            {
                Console.Write("Kaç adet kelime yazmak istersiniz? : ");
                _input = uint.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Yanlış bir karakter girdiniz. Lütfen tekrar deneyiniz!");
                Console.Write("Kaç adet kelime yazmak istersiniz? : ");
                _input = uint.Parse(Console.ReadLine());
            }
            string[] _arr = new string[_input];

            for (int i = 0; i < _input; i++)
            {
                Console.Write("Bir kelime giriniz: ");
                _arr[i] = (i + 1) + ".Kelime: " + Console.ReadLine();
            }
            Array.Reverse(_arr);
            for (int i = 0; i < _input; i++)
            {
                Console.WriteLine(_arr[i]);
            }

        }
        public static void question4()
        {
            //? Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.Write("Bir cümle giriniz: ");
            string _input = Console.ReadLine();
            int _wordsLength = _input.Split(" ").Length;
            string[] _words = new string[_wordsLength];
            for (int x = 0; x < _wordsLength; x++)
            {
                _words[x] = _input.Split(" ")[x];
            }
            int _sumWords = 0;
            int _sumLetters = 0;
            foreach (var item in _words)
            {
                Console.WriteLine("Kelime: {0}, Harf sayısı: {1}", item, item.Length);
                _sumWords++;
                _sumLetters += item.Length;
            }
            Console.WriteLine("Toplam kelime sayısı: {0}", _sumWords);
            Console.WriteLine("Toplam harf sayısı: {0}", _sumLetters);
        }
    }
}