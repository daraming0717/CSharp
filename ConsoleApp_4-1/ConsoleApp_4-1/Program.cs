using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int m500, m100, m50, m10;
            int r500, r100, r50, r10;

            Console.Write("교환할 돈은 얼마? : ");
            money = int.Parse(Console.ReadLine());

            m500 = money / 500;
            r500 = money % 500;
            m100 = r500 / 100;
            r100 = r500 % 100;
            m50 = r100 / 50;
            r50 = r100 % 50;
            m10 = r50 / 10;
            r10 = r50 % 10;

            Console.WriteLine("오백원 : " + m500);
            Console.WriteLine("백원 : " + m100);
            Console.WriteLine("오십원 : " + m50);
            Console.WriteLine("십원 : " + m10);

        }
    }
}
