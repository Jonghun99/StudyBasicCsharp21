using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Animal
    {
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("잡니다.");
        }
    }
}
