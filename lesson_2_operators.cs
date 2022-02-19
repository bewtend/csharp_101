using System;

namespace csharp_learning
{
    public class lesson_2
    {
        public static void operators()
        {

            //? Atama
            int x = 1;
            int y = 2;
            int z = x + y;
            z = (x + 2) + (x + 4);
            z++;
            z += z;
            z = +z;

            //? Mantıksal
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                System.Console.WriteLine("Burak");
            }
            else if (isSuccess || isCompleted)
            {
                System.Console.WriteLine("not Burak");
            }
            else
            {
                System.Console.WriteLine("Who are u?");
            }

            //? İlişkisel
            //*   <, >, >=, <=, ==, != 

            int num1 = 1;
            int num2 = 2;

            bool result = num1 > num2;      //* Result = false
            bool result1 = num1 < num2;     //* Result = true
            bool result2 = num1 == num2;    //* Result = false
            bool result3 = num1 >= num2;    //* Result = false
            bool result5 = num1 <= num2;    //* Result = false
            bool result7 = num1 != num2;    //* Result == true

            //*  *, /, +, -

            int num3 = 3;
            int num4 = 4;

            num1 = num3 + num4;
            num1 = num3++;
            num1 += num3;
            num1++;


            //* % Mod alır kalanı verir.
            //* tip: bir sayının modu 2 alınırsa ve sonuö 0 çıkarsa eğer o sayı çifttir.
            //* Örnek : 12 % 2 == 0 ise çifttir.

            int num12 = 12;

            if (num12 % 2 == 0) Console.WriteLine(num12.ToString() + " is double.");
        }
    }
}