using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5._03
{
    public abstract class Animal : ISound
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMale{ get; set; }

        public abstract void MakeSound();
    }
}
