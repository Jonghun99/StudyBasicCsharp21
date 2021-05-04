using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Cat : Animal
    {
        //property
        public int Age { get; set; } // get은 값을 가져올때, set은 값을 설정할때

        //생성자
        public Cat()
        {
            this.Age = 0;
        }
        //method
 
        public void Meow()
        {
            Console.WriteLine("야옹!");
        }
    }
}
