using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
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
}
