using System;
namespace csharp_learning
{
    public class lesson_12
    {
        public static void method_overloading()
        {

            //? Out parameters
            string _num1 = "999";
            int outNumber;
            bool _result = int.TryParse(_num1, out outNumber);
            if (_result)
            {
                Console.WriteLine("Successfull!");
            }
            else
            {
                Console.WriteLine("Bad idea!");
            }
            int _num2 = 10;
            int _num3 = 12;
            methods.Topla(_num2, _num3, out int toplam);
            Console.WriteLine(toplam);

            //? Method overloading
        }

    }
    class methods
    {
        public static void Topla(int num1, int num2, out int sum)
        {
            sum = num1 + num2;
        }

        public static void debugPrint(string str)
        {
            Console.WriteLine(str);
        }
        public static void debugPrint(int num)
        {
            Console.WriteLine(num);
        }
    }
}