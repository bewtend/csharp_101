using System;

namespace csharp_learning
{
    public class lesson_13
    {
        public static void method_recursive_extension()
        {
            //? Recursive (Yinelemeli)
            int[] _num = { 3, 3, 3, 3, 3 };
            int result = 1;
            for (int i = 0; i < _num.Length; i++)
                result = result * _num[i];
            Console.WriteLine(result);
            Console.WriteLine(transactions.Expo(3, 5));

            //? Extension
            string _string = "Burak Bilgin";
            bool res = _string.checkSpaces();
            Console.WriteLine(res);
        }

    }
    class transactions
    {
        public static int Expo(int baseNumber, int ceilingNumber)
        {
            if (ceilingNumber < 2) return ceilingNumber;
            return Expo(baseNumber, ceilingNumber - 1) * baseNumber;

            //? Result;
            //? Expo(3,5)
            //? Expo(3,4)*3
            //? Expo(3,3)*3*3
            //? Expo(3,2)*3*3*3
            //? Expo(3,1)*3*3*3*3 => 3*3*3*3*3 
        }
    }

    public static class Extension
    {
        public static bool checkSpaces(this string str)
        {
            return str.Contains(" ");
        }
    }
}