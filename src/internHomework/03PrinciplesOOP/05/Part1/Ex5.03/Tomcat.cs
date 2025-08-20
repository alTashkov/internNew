using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._03
{
    class Tomcat : Animal
    {
        public Tomcat(string name, int age)
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
