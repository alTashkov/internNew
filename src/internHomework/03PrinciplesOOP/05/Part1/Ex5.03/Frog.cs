namespace Ex5._03
{
    class Frog : Animal
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

        public Frog(string name, int age, bool isMale)
        {
            this.name = name;
            this.age = age;
            this.isMale = isMale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}
