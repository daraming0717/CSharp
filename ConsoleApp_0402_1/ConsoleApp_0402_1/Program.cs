using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0402_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, heartNum;
            string numStr, heartStr;
            char ch;

            Console.Write("숫자를 여러 개 입력하세요 : ");
            numStr = Console.ReadLine();

            i = 0;
            ch = numStr[i];
            while (true)
            {
                heartNum = ch - '0';
                heartStr = "";
                for (k = 0; k < heartNum; k++)
                    heartStr += '\u2665';
                // console.WriteLine('\u2265')
                Console.WriteLine(heartStr);
                i++;
                if (i > numStr.Length - 1)
                    break;
                ch = numStr[i];
            }
        }
    }
}
