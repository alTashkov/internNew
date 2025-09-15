using System;
using System.Collections.Generic;
namespace School
{
    internal class Teacher : People
    {
        private HashSet<Discipline> disciplines;

        private int amountOfClasses = 0;

        public HashSet<Discipline> Disciplines
        {
            get { return disciplines; }
            private set { disciplines = value; }
        }

        public int AmountOfClasses
        {
            get { return amountOfClasses; }
            private set { amountOfClasses = value; }
        }

        public Teacher(string name, string comments)
        {
            Name = name;
            disciplines = new HashSet<Discipline>();
            AddComments(comments);
        }

        public Teacher(string name, string comments, int amountOfClasses)
        {
            Name = name;
            disciplines = new HashSet<Discipline>();
            AddComments(comments);
            AmountOfClasses = amountOfClasses;
        }
        public Teacher(string name, string classIdentifier, string comments, int amountOfClasses, HashSet<Discipline> disciplines)
        {
            Name = name;
            this.disciplines = disciplines;
            AddComments(comments);
            AmountOfClasses = amountOfClasses;
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
            if (disciplines.Contains(discipline))
            {
                throw new ArgumentException("The teacher already teaches this discipline!");
            }
            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (!disciplines.Contains(discipline))
            {
                throw new ArgumentException("The teacher doesn't teach this discipline!");
            }
            disciplines.Remove(discipline);
        }
    }
}
