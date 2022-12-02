namespace SumTriangularNumbers
{
    internal class Program
    {
        static void Main()
        {
            int variable2 = 4;
            Console.WriteLine(KataBueno.SumTriangularNumbers(variable2));
        }
    }
    public static class KataBueno
    {
        public static int SumTriangularNumbers(int n)
        {
            if (n <= 0) return 0;
            return (n * (n + 1) * (n + 2)) / 6;
        }
    }
    public static class KataCocinao
    {
        public static int SumTriangularNumbers(int n)
        {
            int suma_numeros = 0;
            int suma_sumas = 0;
            for (int i = 1; i <= n; i++)
            {
                suma_numeros = (i * (i + 1) / 2);
                suma_sumas += suma_numeros; // suma_sumas = suma_sumas + suma_numeros;
            }
            return suma_sumas;
        }
    }

}