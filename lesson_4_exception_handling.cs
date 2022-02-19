using System;

namespace csharp_learning
{
    public class lesson_4
    {
        public static void exception()
        {
            int _input;

            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                _input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: " + _input);
            }
            // catch (Exception exp)  //! Tek başına bütün hataları yakalar!
            // {
            //     System.Console.WriteLine(exp.Message.ToString());
            // }
            catch (ArgumentNullException exp) //! Sadece null olanları yakalar!
            {
                System.Console.WriteLine(exp.Message.ToString());
            }
            catch (FormatException exp) //! Veri tipi uyumsuz olanları yakalar!
            {
                System.Console.WriteLine(exp.Message.ToString());

            }
            finally
            {
                Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler...");
            }
        }
    }
}