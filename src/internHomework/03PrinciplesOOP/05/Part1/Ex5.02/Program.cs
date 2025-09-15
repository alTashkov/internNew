using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5._02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(10);

            Student student1 = new Student("Georgi", "Georgiev");
            Student student2 = new Student("Ivan", "Stefanov");
            Student student3 = new Student("Stefan", "Iliev");
            Student student4 = new Student("Ivo", "Naydenov");
            Student student5 = new Student("Alexandar", "Tashkov");
            Student student6 = new Student("Mihail", "Bilalov");
            Student student7 = new Student("Michael", "Cors");
            Student student8 = new Student("Jivko", "Petrov");
            Student student9 = new Student("Yavor", "Yavorov");
            Student student10 = new Student("Kristian", "Iliev");

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);
            students.Add(student8);
            students.Add(student9);
            students.Add(student10);

            Random random = new Random();

            for (int i = 0; i < students.Count; i++)
            {
                students[i].Grade = random.Next(2,7);
            }

            students = students.OrderBy(x => x.Grade).ToList();

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Student {i + 1}: {students[i].FirstName} {students[i].LastName} \nGrade: {students[i].Grade}");
                Console.WriteLine();
            }

            List<Worker> workers = new List<Worker>(10);
            Worker worker1 = new Worker("Petkan", "Draganov");
            Worker worker2 = new Worker("Ivan", "Ivanov");
            Worker worker3 = new Worker("Stefan", "Mitrev");
            Worker worker4 = new Worker("Petar", "Dimitrov");
            Worker worker5 = new Worker("Alexandar", "Tashkov1");
            Worker worker6 = new Worker("Alexandar", "Tashkov2");
            Worker worker7 = new Worker("Alexandar", "Tashkov3");
            Worker worker8 = new Worker("Alexandar", "Tashkov4");
            Worker worker9 = new Worker("Alexandar", "Tashkov5");
            Worker worker10 = new Worker("Alexandar", "Tashkov6");

            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);
            workers.Add(worker4);
            workers.Add(worker5);
            workers.Add(worker6);
            workers.Add(worker7);
            workers.Add(worker8);
            workers.Add(worker9);
            workers.Add(worker10);

            for (int i = 0; i < workers.Count; i++)
            {
                workers[i].WeekSalary = random.Next(300,400);
                workers[i].WorkHoursPerDay = random.Next(7,9);
            }

            workers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine($"Worker {i+1}: {workers[i].FirstName} {workers[i].LastName} \n$ {workers[i].WeekSalary * 4} at {workers[i].WorkHoursPerDay} hours per day" +
                    $"\n$ {workers[i].MoneyPerHour():F2} per hour.");
                Console.WriteLine();
            }
            
            List<Human> humans = new List<Human>();
            for (int i = 0; i < workers.Count; i++)
            {
                Human human = workers[i];
                humans.Add(human);
            }
            for (int j = 0; j < students.Count; j++)
            {
                Human human = students[j];
                humans.Add(students[j]);
            }

            humans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            Console.WriteLine("Humans sorted by name: ");
            Console.WriteLine("----------------------");
            for (int z = 0; z < humans.Count; z++)
            {
                Console.WriteLine($"{humans[z].FirstName} {humans[z].LastName}");
            }
        }
    }
}
