using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _grade;
        private double _gpa;

        public int Grade
        {
            get { return _grade; }

            set
            {
                if ((value < 1) || (value > 12))
                {
                    _grade = 0;
                }
                else
	            {
                    _grade = value;
                };
            }
        }

        public double GPA {
            get { return _gpa; }

            set
            {
                if ((value < 1) || (value > 4))
                {
                    _gpa = 0;
                }
                else
	            {
                    _gpa = value;
                }
            }
        }

        public static List<Student> StarStudents(List<Student> students)
        {
            var selected = from student in students
                           where student.GPA >= 3 &&
                                 student.Grade >= 9 &&
                                 student.Grade <= 12
                           orderby student.Grade descending,
                                   student.GPA descending,
                                   student.LastName ascending,
                                   student.FirstName ascending
                          select student;

            List<Student> selectedStudents = selected.ToList();

            return selectedStudents;
        }
    }
}
