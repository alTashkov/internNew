using System;
namespace Ex5._03
{
    class Kitten : Cat
    {
        public Kitten(string name, int age, bool isMale = false)
            :base(name, age, isMale) 
        {
            Name = name;
            Age = age;
            IsMale = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Soft Meow!");
        }
    }
}
