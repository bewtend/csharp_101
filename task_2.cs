using System.Collections;
using System;
using System.Collections.Generic;

namespace csharp_learning
{
    public class task_2
    {
        private static void _question1_input()
        {
            ArrayList _input = new ArrayList();
            ArrayList _asal = new ArrayList();
            ArrayList _asalOlmayan = new ArrayList();
            int _asalToplam = 0;
            int _asalOrtalama = 0;
            int _asalOlmayanToplam = 0;
            int _asalOlmayanOrtalama = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");

                _input.Add(int.Parse(Console.ReadLine()));
                if ((int)_input[i] < 0)
                {
                    break;
                }
                else if ((int)_input[i] == 2)
                {
                    _asal.Add(_input[i]);
                    _asalToplam += (int)_input[i];
                }
                else if ((int)_input[i] % 2 == 0 && (int)_input[i] != 2)
                {
                    _asalOlmayan.Add(_input[i]);
                    _asalOlmayanToplam += (int)_input[i];
                }
                else
                {
                    _asal.Add(_input[i]);
                    _asalToplam += (int)_input[i];
                }

            }
            _asal.Sort();
            _asalOlmayan.Sort();

            if (_asalToplam > _asal.Count) _asalOrtalama = _asalToplam / _asal.Count;
            if (_asalOlmayanToplam > _asalOlmayan.Count) _asalOlmayanOrtalama = _asalOlmayanToplam / _asalOlmayan.Count;

            Console.Write($"Asal sayılar: ");
            foreach (var item in _asal) Console.Write(item + ", ");
            Console.WriteLine("");
            Console.WriteLine($"Asal sayılar ortalaması: {_asalOrtalama}");
            Console.WriteLine($"Asal sayılar toplamı: {_asalToplam} ");

            Console.Write($"Asal olmayan sayılar: ");
            foreach (var item in _asalOlmayan) Console.Write(item + ", ");
            Console.WriteLine("");
            Console.WriteLine($"Asal olmayan sayılar ortalaması: {_asalOlmayanOrtalama}");
            Console.WriteLine($"Asal olmayan sayılar toplamı: {_asalOlmayanToplam} ");

        }
        public static void question1()
        {
            //? Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //? * Negatif ve numeric olmayan girişleri engelleyin.
            //? * Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //? * Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            try
            {
                _question1_input();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Girdiğiniz değer numeric değildir! Lütfen tekrar deneyiniz.");
                try
                {
                    _question1_input();
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Çok fazla hata yaptınız! Tekrar denemek için programı tekrar başlatınız.");
                    throw;
                }
            }
        }


        public static void question2()
        {
            //? Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            //? Her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
            //? (Array sınıfını kullanarak yazınız.)

            int[] _input = new int[20];

            int[] _lowNumber = new int[3];
            int _lowToplam = 0;
            int _lowOrtalama = 0;
            int[] _highNumber = new int[3];
            int _highToplam = 0;
            int _highOrtalama = 0;

            for (int i = 0; i < _input.Length; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                _input[i] = int.Parse(Console.ReadLine());
                if (_input[i] < 0)
                {
                    Console.WriteLine("0'dan küçük sayı giremezsiniz!");
                    break;
                }
                else if (i == 19)
                {
                    for (int k = 0; k < _lowNumber.Length; k++)
                    {
                        Array.Sort(_input);
                        _lowNumber[k] = _input[k];
                        _lowToplam += _input[k]; ;
                        Array.Reverse(_input);
                        _highNumber[k] = _input[k];
                        _highToplam += _input[k];
                    }
                }
            }

            _lowOrtalama = _lowToplam / _lowNumber.Length;
            _highOrtalama = _highToplam / _highNumber.Length;

            Console.Write("En küçük ilk 3 sayı: ");
            foreach (var item in _lowNumber) Console.Write(item + ", ");
            Console.WriteLine("");
            if (_lowNumber.Length == 3) Console.WriteLine("En küçük ilk 3 sayının ortalaması: " + (_lowToplam / _lowNumber.Length));
            Console.Write("En büyük ilk 3 sayı: ");
            foreach (var item in _highNumber) Console.Write(item + ", ");
            Console.WriteLine("");
            if (_lowNumber.Length == 3) Console.WriteLine("En büyük ilk 3 sayının ortalaması: " + (_highToplam / _highNumber.Length));
            Console.WriteLine("Ortalamaların toplamı: " + (_highOrtalama + _lowOrtalama));

        }

        public static void question3()
        {
            //? Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            Console.Write("Bir cümle ya da kelime giriniz: ");
            string _input = Console.ReadLine();
            List<char> _vowels = new List<char>();
            char[] _letters = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            foreach (char item in _input)
            {
                if (Array.Exists(_letters, element => item == element))
                {
                    _vowels.Add(item);
                }
            }
            _vowels.Sort();
            Console.Write("Girdiğiniz değerdeki sesli harfler: ");
            foreach (var item in _vowels) Console.Write(item + ", ");
        }


    }
}