using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._03
{
    class Kitten : Animal
    {
        public Kitten(string name, int age)
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
