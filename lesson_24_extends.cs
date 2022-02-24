namespace csharp_learning
{
    public class lesson_24
    {
        public static void _extends()
        {
            //? Canlılar 
            //?     * Havyanlar 
            //?         - Sürüngenler 
            //?         - Kuşlar
            //?     * Bitkiler
            //?         - Tohumlu
            //?         - Tohumsuz

            Tohumlu bitki = new Tohumlu();
            bitki.Ureme();

            Surungenler yılan = new Surungenler();
            yılan.Hareket();
        }
    }
}