using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            i = 0;
            while (i < 9)
            {
                if(i < 5)
                {
                    k = 0;
                    while (k < 4 - i)
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
                    while (k < i - 4)
                    {
                        Console.Write(" ");
                        k++;
                    }
                    k = 0;
                    while (k < (9 - i) * 2 - 1)
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
