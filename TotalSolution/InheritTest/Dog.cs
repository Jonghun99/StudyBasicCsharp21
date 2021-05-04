using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Dog : Animal
    {
        //property
        public int Age { get; set; } // get은 값을 가져올때, set은 값을 설정할때
        public string Color { get; set; }
        
        //생성자
        public Dog()
        {
            this.Color = "흰색";
        }

        //method
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }
}
