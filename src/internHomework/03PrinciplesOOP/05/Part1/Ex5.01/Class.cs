using System;
using System.Collections.Generic;

namespace School
{
    internal class Class : ICommentable
    {
        private string comments;

        private string uniqueIdentifier;

        private HashSet<Student> students;

        private HashSet<Teacher> teachers;

        public string UniqueIdentifier {
            get { return uniqueIdentifier; }
            private set { uniqueIdentifier = value; }
        }

        public string Comments {
            get {  return comments; }
        }

        public HashSet<Student> Students
        {
            get { return students; }
            private set { students = value; }
        }

        public HashSet<Teacher> Teachers
        {
            get { return teachers; }
            private set { teachers = value; }
        }

        public Class(string uniqueId)
        {
            UniqueIdentifier = uniqueId;
            Teachers = new HashSet<Teacher>();
            Students = new HashSet<Student>();
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
            if (teachers.Contains(teacher))
            {
                throw new ArgumentException("This teacher already teaches this class!");
            }
            teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!teachers.Contains(teacher))
            {
                throw new ArgumentException("This teacher doesn't teach this class!");
            }
            teachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            if (students.Contains(student))
            {
                throw new ArgumentException("This student is already in this class!");
            }
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!students.Contains(student))
            {
                throw new ArgumentException("This student is not in this class!");
            }
            students.Remove(student);
        }

        public void AddComments(string comments)
        {
            this.comments = comments;
        }
    }
}
