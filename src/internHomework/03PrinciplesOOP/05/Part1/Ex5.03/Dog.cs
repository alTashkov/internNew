using System;
namespace Ex5._03
{
    public class Dog : Animal
    {
        public Dog(string name, int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
