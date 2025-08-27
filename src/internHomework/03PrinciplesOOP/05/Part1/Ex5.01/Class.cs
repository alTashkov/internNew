using System;
using System.Collections.Generic;

namespace School
{
    class Class : IHaveComments
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
            teachers = new HashSet<Teacher>();
            students = new HashSet<Student>();
        }
        public Class(string uniqueId, HashSet<Teacher> teachers)
        {
            UniqueIdentifier = uniqueId;
            this.teachers = teachers;
            students = new HashSet<Student>();
        }
        public Class(string uniqueId, HashSet<Teacher> teachers, HashSet<Student> students)
        {
            UniqueIdentifier = uniqueId;
            this.teachers = teachers;
            this.students = students;
        }
        public void AddTeacher(Teacher teacher)
        {
            if (teachers.Contains(teacher))
            {
                throw new ArgumentException("This teacher is already teaching this student!");
            }
            teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!teachers.Contains(teacher))
            {
                throw new ArgumentException("This teacher doesn't teach this student!");
            }
            teachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            if (students.Contains(student))
            {
                throw new ArgumentException("This teacher doesn't teach this student!");
            }
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!students.Contains(student))
            {
                throw new ArgumentException("This teacher doesn't teach this student!");
            }
            students.Add(student);
        }

        public void AddComments(string comments)
        {
            this.comments = comments;
        }
    }
}
