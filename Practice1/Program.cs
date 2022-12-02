namespace Practice1
{
    internal class Program
    {
        static void Main()
        {
            long variable1 = 10;
            Console.WriteLine(KataBueno.RowSumOddNumbers(variable1));
        }
    }

    public static class KataBueno
    {
        public static long RowSumOddNumbers(long n)
        {
            return (long)Math.Pow(n, 3);
        }
    }
    
}
