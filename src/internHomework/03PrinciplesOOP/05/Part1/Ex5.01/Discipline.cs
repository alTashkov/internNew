using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Discipline
    {
        string Comments { get; set; }
        string Name { get; set; }
        int NumberOfLectures { get; set; }
        int NumberOfExercises { get; set; }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            Name = name;
            NumberOfLectures = numberOfLectures;
            NumberOfExercises = numberOfExercises;
        }
    }
}
