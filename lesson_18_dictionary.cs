using System;
using System.Collections.Generic;
namespace csharp_learning
{
    public class lesson_18
    {
        public static void dictionary()
        {
            Dictionary<int, string> _dic = new Dictionary<int, string>()
            {
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"},
                {4,"Dört"},
                {5,"Beş"},
                {6,"Altı"}
            };

            //? Add
            //? Eleman eklemek için kullanılır.
            _dic.Add(7, "Yedi");

            //? İçerisindeki elemanlara erişme
            Console.WriteLine(_dic[1]); //? Tip: index olarak 1 den başlar.
            foreach (var item in _dic) Console.WriteLine(item + " = " + item.Key + " - " + item.Value);

            //? Count
            //? Eleman sayısını verir.
            Console.WriteLine(_dic.Count);

            //? Containst
            //? Constains aradığınız değerin boolean değerini geri döndürür
            Console.WriteLine("Key: " + _dic.ContainsKey(1) + " ,Value: " + _dic.ContainsValue("1"));

            //? Remove
            //? Silmek istediğiniz değerin key değerini girerek remove edebilirsiniz.
            Console.WriteLine(_dic.Remove(1));


            //? Key ve Value listeleme
            foreach (var item in _dic.Keys) Console.WriteLine(item);
            foreach (var item in _dic.Values) Console.WriteLine(item);
        }
    }
}