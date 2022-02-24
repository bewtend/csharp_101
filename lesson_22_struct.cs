using System;
namespace csharp_learning
{
    public class lesson_22
    {

        //? Temel farkı class heap'te tutar, struct ise stack üzerinde tutar,
        //? Önerilen ise 16 byte'a kadar verileri struct içerisinde tutmak.
        public static void _struct()
        {
            //? Class
            Dikdortgen _dikdortgen = new Dikdortgen()
            {
                longEdge = 4,
                shortEdge = 5,
            };
            Console.WriteLine(_dikdortgen.CalculateArea());

            //? Struct
            // Dikdortgen_2 _example = Dikdortgen_2(); //? Classtan farkı olan bu kullanıma izin vermez
            Dikdortgen_2 _dikdortgen2 = new Dikdortgen_2(4, 5);
            // _dikdortgen2.longEdge = 4;
            // _dikdortgen2.shortEdge = 5;
            Console.WriteLine(_dikdortgen2.CalculateArea());

        }
    }
    class Dikdortgen
    {
        public int longEdge;
        public int shortEdge;

        public Dikdortgen() { }
        public long CalculateArea()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    struct Dikdortgen_2
    {
        public int longEdge;
        public int shortEdge;
        public Dikdortgen_2(int shortEdge, int longEdge)
        {
            this.shortEdge = shortEdge;
            this.longEdge = longEdge;
        }
        public long CalculateArea()
        {
            return this.shortEdge * this.longEdge;
        }
    }
}