using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp118
{
    class Program
    {
        static void Main(string[] args)
        {
            int decData = 12341234;
            string hexData = "ABCDEF";

            Console.WriteLine(Convert.ToString(decData,10));
            Console.WriteLine(Convert.ToString(decData, 2));
            Console.WriteLine(Convert.ToString(decData, 16));
            Console.WriteLine("-----------------------------");
            Console.WriteLine(hexData);
            Console.WriteLine(Convert.ToString(Convert.ToInt32(hexData, 16), 10));
            Console.WriteLine(Convert.ToString(Convert.ToInt32(hexData, 16), 2));
        }
    }
}
