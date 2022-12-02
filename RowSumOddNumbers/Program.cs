namespace RowSumOddNumbers
{
    internal class Program
    {
        static void Main()
        {
            int variable1 = 4;
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

