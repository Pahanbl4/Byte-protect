using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число N: ");
                int N = Int32.Parse(Console.ReadLine());

                if (Validation(N, out int a, out int b, out int c))
                {
                    Console.WriteLine("Да  {0} * {1} * {2} = {3}", a, b, c, N);
                }
                else
                {
                    Console.WriteLine("Нет");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены неверные данные");
                return;
            }

        }

        public static bool Validation(int N, out int a, out int b, out int c)
        {
            a = 1;
            b = 2;
            c = 3;

            if (N < a * b * c)
                return false;

            if (N == a * b * c)
                return true;

            for (int i = c; i < N - 1; i++)
            {
                if (IsPrime(i))
                {
                    a = b;
                    b = c;
                    c = i;

                    if (N == a * b * c)
                        return true;
                }
            }
            return false;
        }

        public static bool IsPrime(int x)
        {

            if (x < 2) return false;
            if (((x % 2) == 0) && (x != 2))
                return false;

            int i = 3;
            while (i <= Math.Truncate(Math.Sqrt(x)))
            {
                if ((x % i) == 0) return false;
                i += 2;
            }
            return true;
        }

    }
}

