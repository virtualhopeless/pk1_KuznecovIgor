using System;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, j, i, x;
            Console.Write("Введите число: ");
            n = int.Parse(Console.ReadLine());
            i = 0;
            j = 0;
            x = 0;
            if (n % 2 == 1)
            {
                m = n;
                for (j = m; i <= 2 * m; j++)
                {
                    if (j % 2 == 0) continue;
                    if (j >= 2 * m) break;
                    x = x + j;
                }
                Console.WriteLine(x);
            }
            if (n % 2 == 0)
            {
                m = n + 1;
                for (j = m; i <= 2 * m; j++)
                {
                    if (j % 2 == 0) continue;
                    if (j >= 2 * m) break;
                    x = x + j;
                }
                Console.WriteLine(x);
            }
        }
    }
}