using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   //예외가 발생할 가능성이 있는 로직
                Console.Write("값을 입력하세요(소수점을 입력하세요) : ");
                double input = double.Parse(Console.ReadLine());
                int ival = 10;

                Console.WriteLine($"입력된 값은 {input}입니다");
                Console.WriteLine($"숫자값은 {ival}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
       
        }
    }
}
