using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : People
    {
        private string classIdentifier;
        private string Comments { get; set; }
        public Student(string name, string classIdentifier, string comments)
        {
            Name = name;
            this.classIdentifier = classIdentifier;
            Comments = comments;
        }
    }
}
