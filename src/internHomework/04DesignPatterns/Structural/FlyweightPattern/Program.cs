using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    internal class Program
    {
        //Allows the program to support large quantities of objects by keeping the memory consumption low.
        //It shares parts of the state of the objects -  saves RAM by caching same data.
        static void Main(string[] args)
        {
            TreeFactory factory = new TreeFactory();

            List<Tree> forest = new List<Tree>();

            Random rnd = new Random();

            for (int i = 0; i < 100000; i++)
            {
                int x = rnd.Next(0, 1000);
                int y = rnd.Next(0, 1000);

                ITreeFlyweight type = factory.GetTreeType("Oak", "Green", "Rough");
                forest.Add(new Tree(x, y, type));
            }

            Console.WriteLine($"Forest created with {forest.Count} trees.");

            for (int i = 0; i < 5; i++)
            {
                forest[i].Display();
            }

            Console.ReadLine();
        }
    }
}
