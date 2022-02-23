using System;
using System.Collections;
using System.Collections.Generic;
namespace csharp_learning
{
    public class lesson_17
    {
        public static void arraylist()
        {
            //? Add ile herhangi bir değişkeni listeye alabilirsiniz.
            ArrayList _arr = new ArrayList();
            // _arr.Add(1);
            // _arr.Add("Burak");
            // _arr.Add(1.0);
            // _arr.Add(true);
            // _arr.Add('A');


            //? AddRange
            //? Sadec Collection tipinde eklenir.

            // string[] _ar = new string[5];
            // _arr.AddRange(_ar);

            List<int> _list = new List<int>() { 1, 2, 5, 4, 7, 3 };
            _arr.AddRange(_list);

            foreach (var item in _arr) Console.WriteLine(item);

            //? Sort
            //? Tip: farklı tipte değişkenler olursa hata alırsınız.
            _arr.Sort();
            foreach (var item in _arr) Console.WriteLine(item);

            //? Binary Search
            //? Girdiğiniz değerin hangi indexte olduğunu söyler.
            Console.WriteLine(_arr.BinarySearch(3));

            //? Reverse
            //? Listeyi tersine çevirir
            _arr.Reverse();
            foreach (var item in _arr) Console.WriteLine(_arr);

            //? Clear
            _arr.Clear();

        }
    }
}