using System;

namespace PrototypePattern
{
    public class Enemy : IEnemyPrototype
    {
        private string name;

        private int health;

        private string weapon;

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Enemy(string name, int health, string weapon)
        {
            this.name = name;
            this.health = health;
            this.weapon = weapon;
        }

        public IEnemyPrototype Clone()
        {
            return (IEnemyPrototype)this.MemberwiseClone();
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks with {Weapon}, Health: {Health}");
        }
    }
}
