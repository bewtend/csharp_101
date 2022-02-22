using System;

namespace csharp_learning
{
    public class lesson_14
    {
        public static void string_methods()
        {
            string _input = "Burak Bilgin";
            string _input2 = "Burak";
            //? Length 
            Console.WriteLine(_input.Length); //? string uzunluğunu verir (boşluklar dahil)

            //? ToUpper && ToLower
            Console.WriteLine(_input.ToLower()); //? harfleri küçük yapar.
            Console.WriteLine(_input.ToUpper()); //? harfleri büyük yapar.

            //? Concat
            Console.WriteLine(String.Concat(_input, " Merhaba!")); //? String ekler.

            //? Compare && CompareTo
            Console.WriteLine(_input.CompareTo(_input2)); //? result => 1.Değişken 2.değişkenin karakter sayısından büyükse 1 değilse -1 eşit ise 0;
            Console.WriteLine(String.Compare(_input, _input2, true)); //? result => 0,1,-1 : ekstra ignore case özelliği mevcut

            //? Contains
            Console.WriteLine(_input.Contains(_input2));
            Console.WriteLine(_input.EndsWith("Bilgin"));
            Console.WriteLine(_input.StartsWith("Burak"));

            //? IndexOf
            Console.WriteLine(_input.IndexOf("Burak")); //? ilk bulduğu yerde B harfinin indexini verir. Bulamazsa -1 verir.
            Console.WriteLine(_input.LastIndexOf("i"));

            //? Insert
            Console.WriteLine(_input.Insert(0, "Merhaba "));

            //? PadLeft && PadRight
            Console.WriteLine(_input + _input2.PadLeft(30));
            Console.WriteLine(_input + _input2.PadLeft(10, '*'));

            //? Remove
            Console.WriteLine(_input.Remove(5)); //? 5.indexten sonrasini siler
            Console.WriteLine(_input.Remove(0, 4)); //? belirlenen aralığı siler

            //? Replace
            Console.WriteLine(_input.Replace("i", "e"));

            //? Split
            Console.WriteLine(_input.Split(" ").Length);

            //? Substring
            Console.WriteLine(_input.Substring(5));
            Console.WriteLine(_input.Substring(0, 5));

        }
    }
}