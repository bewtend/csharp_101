using System;
using System.Collections.Generic;

namespace csharp_learning
{
    public class lesson_10
    {
        public static void arrays_2()
        {
            int[] _numbers = { 2, 7, 1, 9, 8, 10, 23 };

            //? Sort
            Array.Sort(_numbers); //? result => 1,2,7,8,9,10,23
            foreach (var item in _numbers) Console.WriteLine(item);

            //? Clear
            Array.Clear(_numbers, 0, 2); //? result => 0,0,7,8,9,10,23
            foreach (var item in _numbers) Console.WriteLine(item);

            //? Reverse
            Array.Reverse(_numbers);
            foreach (var item in _numbers) Console.WriteLine(item); //? result => 23,10,9,8,7,0,0

            //? Index Of
            Console.WriteLine(Array.IndexOf(_numbers, 10)); //? result => 1 (kaçıncı indexte olduğunu söyler)

            //? Resize
            Array.Resize<int>(ref _numbers, 9);
            _numbers[7] = 4;
            _numbers[8] = 3;
            foreach (var item in _numbers) Console.WriteLine(item); //? result => 23,10,9,8,7,0,0,4,3

            //? Max

            List<int> _list = new List<int>(){
                1,2,3,4,5,6,
            };

            _list.Sort();
        }
    }
}