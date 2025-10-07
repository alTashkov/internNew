namespace Ex3._02
{
    internal class HumanCreator
    {
        public enum Genders { 
            Male, 
            Female 
        };

        internal class Human
        {
            public Genders Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }

        public void CreateHuman(int age)
        {
            Human human = new Human();

            human.Age = 28;

            if (human.Age % 2 == 0)
            {
                human.Name = "Батката";
                human.Gender = Genders.Male;
            }
            else
            {
                human.Name = "Мацето";
                human.Gender = Genders.Female;
            }
        }
    }
}
