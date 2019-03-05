using System;
using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                {new Student() {LastName = "Smith", FirstName = "Abby", Grade = 1, GPA = 3.25 } },
                {new Student() {LastName = "Wallen", FirstName = "Alex", Grade = 2, GPA = 2.5 } },
                {new Student() {LastName = "Jones", FirstName = "Lauren", Grade = 8, GPA = 2 } },
                {new Student() {LastName = "Star", FirstName = "Drew", Grade = 9, GPA = 3.75 } },
                {new Student() {LastName = "Jordan", FirstName = "Sara", Grade = 10, GPA = 4 } },
                {new Student() {LastName = "Barnes", FirstName = "Cameron", Grade = 11, GPA = 3.5 } },
                {new Student() {LastName = "Pointer", FirstName = "Linsey", Grade = 10, GPA = 3 } },
                {new Student() {LastName = "Fletcher", FirstName = "Ashley", Grade = 9, GPA = 3.25 } },
                {new Student() {LastName = "Williams", FirstName = "Jaden", Grade = 11, GPA = 2.75 } },
                {new Student() {LastName = "Powers", FirstName = "Danielle", Grade = 13, GPA = 2.25 } }
            };

            List<Student> selectedStudents = Student.StarStudents(students);

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student.FirstName);
            }

            Console.ReadLine();
        }
    }
}
