using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : People
    {
        private HashSet<Discipline> Disciplines;
        private string Comments { get; set; }
        private int amountOfClasses { get; set; } = 0;

        public Teacher(string name, string comments)
        {
            Name = name;
            Disciplines = new HashSet<Discipline>();
            Comments = comments;
        }

        public Teacher(string name, string comments, int amountOfClasses)
        {
            Name = name;
            Disciplines = new HashSet<Discipline>();
            Comments = comments;
            this.amountOfClasses = amountOfClasses;
        }
        public Teacher(string name, string classIdentifier, string comments, int amountOfClasses, HashSet<Discipline> disciplines)
        {
            Name = name;
            Disciplines = disciplines;
            Comments = comments;
            this.amountOfClasses = amountOfClasses;
        }

        //public void AddClass(Class classToTeach)
        //{
        //    if (Classes.Contains(classToTeach))
        //    {
        //        throw new ArgumentException("This teacher already teaches this class!");
        //    }
        //    Classes.Add(classToTeach);
        //    AmountOfClasses++;
        //}

        //public void RemoveClass(Class classToRemove)
        //{
        //    if (!Classes.Contains(classToRemove))
        //    {
        //        throw new ArgumentException("This teacher doesn't teach this class!");
        //    }
        //    Classes.Remove(classToRemove);
        //    AmountOfClasses--;
        //}

        public void AddDiscipline(Discipline discipline)
        {
            if (Disciplines.Contains(discipline))
            {
                throw new ArgumentException("The teacher already teaches this discipline!");
            }
            Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (!Disciplines.Contains(discipline))
            {
                throw new ArgumentException("The teacher doesn't teach this discipline!");
            }
            Disciplines.Remove(discipline);
        }
    }
}
