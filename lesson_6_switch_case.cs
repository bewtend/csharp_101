using System;

namespace csharp_learning
{
    public class lesson_6
    {
        public static void switch_case()
        {
            //? Prim ayları
            int _month = DateTime.Now.Month;
            switch (_month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız ve prim alıyorsunuz!");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız ve prim alıyorsunuz!");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız ve prim alıyorsunuz!");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız ve prim alıyorsunuz!");
                    break;
                default:
                    Console.WriteLine("Bu ay prim almıyorsunuz!");
                    break;
            }
        }
    }
}