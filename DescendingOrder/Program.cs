using System.Linq;

namespace DescendingOrder
{
    internal class Program
    {
        static void Main()
        {
            int variable3 = 43134;

            // Formateo de salida de cadenas int por pantalla

            Console.WriteLine(KataCocinao.DigitArray(variable3)[0]);  // Primer Elemento / Cualquier elemento
            Console.WriteLine("[{0}]", string.Join(", ", KataCocinao.DigitArray(variable3))); // Todos los elementos con coma y espacio
            Console.WriteLine(string.Join("", KataCocinao.DigitArray(variable3))); // Todos los elementos juntos (sorted con string.join)
            Console.WriteLine(string.Join("", KataCocinao.ArraySorter(KataCocinao.DigitArray(variable3)))); // Todos los elementos juntos (sorted con string.join)
            Console.WriteLine(KataCocinao.ArrayToInt(KataCocinao.DigitArray(variable3))); // todos los elementos juntos (ArrayToInt)
            Console.WriteLine(KataCocinao.ArrayToInt(KataCocinao.ArraySorter(KataCocinao.DigitArray(variable3)))); // todos los elementos juntos (sorted con ArrayToInt)

            // Array.ForEach(KataCocinao.DigitArray(variable3), Console.WriteLine); // Todos los elementos con salto de línea
        }
    }

    public static class KataBuenoLINQ
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
    }
    public static class KataBuenoNoLINQ
    {
        public static int DescendingOrder(int num)
        {
            char[] arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return Convert.ToInt32(new string(arr));
        }
    }

    public class KataCocinao
    {
        public static int NumDigits(int n)
        {
            if (n < 0)
            {
                n = (n == Int32.MinValue) ? Int32.MaxValue : -n;
            }
            //int a = 0;
            //for (int i = 0 ; i < 10; i++)
            //{
            //    if (n <= i * 9) a = i;
            //    else a = i;
            //}
            //return a;

            if (n < 10) return 1;
            if (n < 100) return 2;
            if (n < 1000) return 3;
            if (n < 10000) return 4;
            if (n < 100000) return 5;
            if (n < 1000000) return 6;
            if (n < 10000000) return 7;
            if (n < 100000000) return 8;
            if (n < 1000000000) return 9;
            return 10;
        }

        public static int[] DigitArray(int n)
        {
            int[] result = new int[NumDigits(n)];
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = n % 10;
                n /= 10;
            }
            return result;
        }
        public static int[] ArraySorter(int[] n)
        {
            Array.Sort(n, n.GetLowerBound(0), n.GetUpperBound(0) + 1);
            Array.Reverse(n, n.GetLowerBound(0), n.GetUpperBound(0) + 1);
            return n;
        }
        public static int ArrayToInt(int[] n)
        {
            int number = 0;
            for (int i = 0; i < n.Length; i++)
            {
                number += n[i] * Convert.ToInt32(Math.Pow(10, n.Length - i - 1));
            }
            return number;
        }

    }
}