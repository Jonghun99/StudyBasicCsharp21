using System;
using System.Collections.Generic;

namespace InheritTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(), new Dog()
            };

            List<Cat> cats = new List<Cat>
            {
                new Cat(), new Cat()
            };

            foreach (Dog item in dogs)
            {
                item.Age = 10;
                item.Color = "흰색";
                item.Eat();
                item.Sleep();
                item.Bark();

                Console.WriteLine("나이 : " + item.Age + " 색깔 : " + item.Color);
            }

            foreach (Cat item in cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();

                Console.WriteLine("나이 : " + item.Age);
            }
        }
    }
}
