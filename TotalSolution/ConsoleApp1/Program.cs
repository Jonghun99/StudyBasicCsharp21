using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Findout
    {
        class Number
        {
            public int number;
        }

        static void Main(string[] args)
        {
            Number i = new Number();
            i.number = 126;
        ff:
            Console.WriteLine("숫자를 입력해주세요 : ");
            int ii = Int32.Parse(Console.ReadLine());

            if (ii == i.number)
            {
                Console.WriteLine("정답입니다!");
            }
            else
            {
                if (ii > i.number)
                {
                    Console.WriteLine($"{ii}보다는 작은 숫자입니다.\n");
                }
                else
                {
                    Console.WriteLine($"{ii}보다는 큰 숫자입니다.\n");
                }
                goto ff;
            }
        }
    }
}
