using System;
namespace Ex5._03
{
    class Frog : Animal
    {
        public Frog(string name, int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}
