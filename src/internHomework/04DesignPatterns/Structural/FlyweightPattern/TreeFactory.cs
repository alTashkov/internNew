using System.Collections.Generic;
using System;
namespace FlyweightPattern
{
    internal class TreeFactory
    {
        private Dictionary<string, ITreeFlyweight> treeTypes = new Dictionary<string, ITreeFlyweight>();

        public ITreeFlyweight GetTreeType(string name, string color, string texture)
        {
            string key = $"{name}_{color}_{texture}";

            if (!treeTypes.ContainsKey(key))
            {
                Console.WriteLine($"Creating new TreeType: {key}");
                treeTypes[key] = new TreeType(name, color, texture);
            }

            return treeTypes[key];
        }
    }
}
