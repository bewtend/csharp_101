using System;

namespace csharp_learning
{
    class Program
    {
        public static void Main(string[] args)
        {
            // byte _byte = 1;         //? 1byte
            // sbyte _sbyte = 1;       //? 1byte
            // short _short = 1;        //? 2byte
            // ushort _ushort = 1;     //? 2byte
            Int16 _int16 = 1;       //? 2byte
            int _int = 1;           //? 4byte 
            Int32 _int32 = 1;       //? 4byte
            // Int64 _int64 = 1;       //? 8byte
            // uint _uint = 1;         //? 4byte
            // long _long = 1;         //? 8byte
            // ulong _ulong = 1;       //? 8byte
            // float _float = 1;       //? 4byte
            // double _double = 1;     //? 8byte
            // decimal _decimal = 1;   //? 16byte
            // char _char = 'c';       //? 2byte
            string _string = "str"; //? infinity

            bool _bool = true;
            // bool _boolean = false;
            DateTime _dateTime = DateTime.Now;
            Console.WriteLine(_dateTime);
            object _object = 'a';
            object _object1 = 1;
            object _object2 = DateTime.Now;
            object _object3 = 0.1;
            // var _var = 'a';
            // var _var1 = 1;
            // var _var2 = 2;
            dynamic f = 1;
            _int = _string.Length;
            _bool = _string.Length > 0;
            _string = _int.ToString();
            _string = (_int16 + _int32).ToString();
            System.Console.WriteLine(_string);
            System.Console.WriteLine(_dateTime.ToString("d"));
        }
    }
}
