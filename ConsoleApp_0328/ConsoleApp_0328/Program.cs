using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0328
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, n;
            i = 0;

            Console.Write("마름모의 지름이 될 수를 입력하시오 : ");
            string a = Console.ReadLine();
            n = int.Parse(a);
            n = n + 1;

            while (i < n - 1)
            {
                if (i < n / 2)
                {
                    k = 0;
                    while (k < (n/2) - 1 - i)
                    {
                        Console.Write(" ");
                        k++;
                    }
                    k = 0;
                    while (k < (2 * i) + 1)
                    {
                        Console.Write('\u2605');
                        k++;
                    }
                }
                else
                {
                    k = 0;
                    while (k < i - (n / 2 - 1))
                    {
                        Console.Write(" ");
                        k++;
                    }
                    k = 0;
                    while (k < (n - 1 - i) * 2 - 1)
                    {
                        Console.Write('\u2605');
                        k++;
                    }
                }
                i++;
                Console.WriteLine();
            }
        }
    }
}
