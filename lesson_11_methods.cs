namespace csharp_learning
{
    public class lesson_11
    {
        public static void methods()
        {
            int x = 5;
            int y = 10;
            System.Console.WriteLine(Topla(x, y));
            method.debugPrint(Topla(x, y));
            var result = method.plusAndIncrement(x, y);
            method.debugPrint(result);
        }
        static int Topla(int a, int b)
        {
            return a + b;
        }


    }

    class method
    {
        public static void debugPrint(int result)
        {
            System.Console.WriteLine(result);
        }

        public static int plusAndIncrement(int var1, int var2)
        {
            var1 += 1;
            var2 += 1;
            return var1 + var2;
        }
    }
}