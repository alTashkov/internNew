using System;
namespace Ex5._03
{
    internal class Cat : Animal
    {
        public Cat(string name, int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
