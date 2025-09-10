namespace PrototypePattern
{
    internal class Program
    {
        //Prototype lets us create new objects by copying an existing object called the "prototype".
        //instead of calling a constructor.
        static void Main(string[] args)
        {
            Enemy strongEnemyPrototype = new Enemy("Enemy1", 200, "Sword");

            Enemy strongEnemy1 = (Enemy)strongEnemyPrototype.Clone();

            Enemy strongEnemy2 = (Enemy)strongEnemyPrototype.Clone();

            strongEnemy1.Attack();

            strongEnemy2.Attack();
        }
    }
}
