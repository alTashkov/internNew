using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._03
{
    public class Dog : Animal
    {
        private string name;

        private int age;

        private bool isMale;

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }

        public Dog(string name, int age, bool isMale)
        {
            this.name = name;
            this.age = age;
            this.isMale = isMale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
