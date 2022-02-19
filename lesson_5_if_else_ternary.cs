using System;

namespace csharp_learning
{
    public class lesson_5
    {
        public static void if_else()
        {

            int _time = DateTime.Now.Hour;

            if (_time < 11 && _time > 7) System.Console.WriteLine("Günaydın!"); //? Eğer if koşulunuzun sonucu tek satır ise bu şekilde yanına yazabilirsiniz.

            else if (_time < 21 && _time > 12)
            {
                System.Console.WriteLine("İyi akşamlar!");
            }
            else
            {
                System.Console.WriteLine("İyi geceler!");
            }


            //* short if-else

            String result = (_time < 11 && _time > 7) ? "Günaydın!" : (_time < 21 && _time > 12) ? "İyi akşamlar" : "İyi geceler";
            Console.WriteLine(result);
        }
    }
}