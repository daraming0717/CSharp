using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp_0402_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, cloverNum;
            string numStr, cloverStr;
            char ch;

            Console.Write("16진수를 여러 개 입력하세요 : ");
            numStr = Console.ReadLine();

            i = 0;
            ch = numStr[i];

            while (true)
            {
                cloverNum = 0;
                if('0' <= ch && ch <= '9')
                    cloverNum = ch - '0';
                else if('a' <= ch && ch <= 'f')
                    cloverNum = ch - 'a' + 10;
                else if('A' <= ch && ch <= 'F')
                    cloverNum = ch - 'A' + 10;
                if (cloverNum != 0)
                {
                    cloverStr = "";
                    for (k = 0; k < cloverNum; k++)
                        cloverStr += '\u2663';
                    // console.WriteLine('\u2263')
                    Console.WriteLine(cloverStr);
                }
                i++;
                if (i > numStr.Length - 1)
                    break;
                ch = numStr[i];
            }
        }
    }
}
