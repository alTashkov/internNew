using System;
namespace Ex5._03
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age, bool isMale = true) 
            :base(name, age, isMale)
        {
            Name = name;
            Age = age;
            IsMale = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Loud YOWL!");
        }
    }
}
