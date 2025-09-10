using System;
namespace Ex5._03
{
    class Tomcat : Animal
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
            set { isMale = true; }
        }

        public Tomcat(string name, int age)
        {
            this.name = name;
            this.age = age;
            isMale = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Loud YOWL!");
        }
    }
}
