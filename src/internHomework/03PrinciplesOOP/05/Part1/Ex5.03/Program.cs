namespace Ex5._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo1 = new Animal[]
            {
                new Cat("Dorko",5,false),
                new Frog("Jaba",10,false),
                new Tomcat("Georgi",20),
                new Cat("Marko",12,true),
                new Kitten("Kotka",2)
            };

            Console.WriteLine("You entered zoo1!\n-----------");
            for (int i = 0; i < zoo1.Length; i++)
            {
                zoo1[i].MakeSound();
            }

            Console.WriteLine("---------");
            Console.WriteLine("Average age for kittens in zoo1: " + FindAverageAge(zoo1, typeof(Kitten)));
            Console.WriteLine("Average age for cats in zoo1: " + FindAverageAge(zoo1, typeof(Cat)));
            Console.WriteLine("Average age for frogs in zoo1: " + FindAverageAge(zoo1, typeof(Frog)));
            Console.WriteLine("Average age for tomcats in zoo1: " + FindAverageAge(zoo1, typeof(Tomcat)));
            Console.WriteLine();

            
            Animal[] zoo2 = new Animal[]
            {
                new Cat("Ivan",23,false),
                new Frog("Jaba2",15,false),
                new Tomcat("Petar",30),
                new Cat("Stef",1,true),
                new Kitten("Mia",22),
                new Kitten("Grisha",32),
                new Kitten("Klara",12),
            };

            Console.WriteLine("You entered zoo2!\n-----------");
            for (int i = 0; i < zoo2.Length; i++)
            {
                zoo2[i].MakeSound();
            }

            Console.WriteLine("------------");
            Console.WriteLine("Average age for tomcats in zoo2: " + FindAverageAge(zoo2, typeof(Tomcat)));
            Console.WriteLine("Average age for frogs in zoo2: " + FindAverageAge(zoo2, typeof(Frog)));
            Console.WriteLine("Average age for cats in zoo2: " + FindAverageAge(zoo2, typeof(Cat)));
            Console.WriteLine("Average age for kittens in zoo2: " + FindAverageAge(zoo2, typeof(Kitten)));

        }

        static double FindAverageAge(Animal[] animals, Type animalType)
        {
            double sum = 0;
            double amountOfAnimals = 0;

            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].GetType() == animalType)
                {
                    sum += animals[i].Age;
                    amountOfAnimals++;
                }
            }

            return amountOfAnimals > 0 ? sum / amountOfAnimals : 0;
        }
    }
}
