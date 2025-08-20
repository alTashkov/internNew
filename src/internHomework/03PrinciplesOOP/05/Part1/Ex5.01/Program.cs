using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class People
    {
        public string Name { get; set; }
    }

    class Class
    {
        private string UniqueIdentifier { get; }
        private string Comments { get; set; }

        private HashSet<Student> Students;

        private HashSet<Teacher> Teachers;
        public Class(string uniqueId)
        {
            UniqueIdentifier = uniqueId;
            Teachers = new HashSet<Teacher>();
            Students = new  HashSet<Student>();
        }
        public Class(string uniqueId, HashSet<Teacher> teachers)
        {
            UniqueIdentifier = uniqueId;
            Teachers = teachers;
            Students = new HashSet<Student>();
        }
        public Class(string uniqueId, HashSet<Teacher> teachers, HashSet<Student> students)
        {
            UniqueIdentifier = uniqueId;
            Teachers = teachers;
            Students = students;
        }
        public void AddTeacher(Teacher teacher)
        {
            if (Teachers.Contains(teacher))
            {
                throw new ArgumentException("This teacher is already teaching this student!");
            }
            Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!Teachers.Contains(teacher))
            {
                throw new ArgumentException("This teacher doesn't teach this student!");
            }
            Teachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            if (Students.Contains(student))
            {
                throw new ArgumentException("This teacher doesn't teach this student!");
            }
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                throw new ArgumentException("This teacher doesn't teach this student!");
            }
            Students.Add(student);
        }
    }

    class Student : People
    {
        private string classIdentifier;
        private string Comments { get; set; }
        public Student(string name, string classIdentifier, string comments)
        {
            this.Name = name;
            this.classIdentifier = classIdentifier;
            Comments = comments;
        }
    }

    class Teacher : People
    {
        private HashSet<Discipline> Disciplines;
        private string Comments { get; set; }
        private int amountOfClasses { get; set; } = 0;

        public Teacher(string name, string comments)
        {
            this.Name = name;
            Disciplines = new HashSet<Discipline>();
            Comments = comments;
        }

        public Teacher(string name, string comments, int amountOfClasses)
        {
            this.Name = name;
            Disciplines = new HashSet<Discipline>();
            Comments = comments;
            amountOfClasses = amountOfClasses;
        }
        public Teacher(string name, string classIdentifier, string comments, int amountOfClasses, HashSet<Discipline> disciplines)
        {
            this.Name = name;
            Disciplines = disciplines;
            Comments = comments;
            amountOfClasses = amountOfClasses;
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
