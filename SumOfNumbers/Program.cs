namespace SumOfNumbers
{
    internal class Program
    {
        static void Main()
        {
            int variable1 = 10;
            int variable2 = -2;
            Console.WriteLine(KataCocinao.GetSum(variable1, variable2)); ;
        }   
    }

    public static class KataBueno
    {
        public static int GetSum(int a, int b)
        {
            return (a + b) * (Math.Abs(a - b) + 1) / 2;
        }
    }
    public static class KataCocinao
    {
        public static int GetSum(int a, int b)
        {
            if (a == b) return a;
            else
            {
                int sum_numbers = 0;
                if (a < b) for (int i = a; i <= b; i++) sum_numbers = sum_numbers + i; // sum_numbers = sum_numbers + i;
                if (a > b) for (int i = b; i <= a; i++) sum_numbers = sum_numbers + i; // sum_numbers = sum_numbers + i;
                return sum_numbers;
            }
        }
    }
}
