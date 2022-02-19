using System;

namespace csharp_learning
{
    public class lesson_3
    {
        //? Implicit Conversion 
        public static void imp_conversion()
        {
            byte _byte = 5;
            sbyte _sbyte = 10;
            short _short = 20;
            int _int = 40;

            _int = _byte + _sbyte + _short + _int;

            long _long = _byte + _sbyte + _short + _int;
            float _float = _byte + _sbyte + _short + _int + _long;
            System.Console.WriteLine(_float);
        }

        //? Explicit Conversion
        public static void exp_conversion()
        {
            int _int = 5;
            byte _byte = (byte)_int; //? cast etmeye çalışır.


            float _float = 10f;
            _byte = (byte)_float;


            string _string = _int.ToString();
            _string = Convert.ToString(_int);

            _string = "10";

            _int = Convert.ToInt32(_string);

            int result = _int + 5; //* Result = 5;

            _int = Int32.Parse(_string);

        }
    }
}