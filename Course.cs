using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes___Method__
{
    public class Course
    {
        string _courseName;
        string _teacher;
        List<Student> _classRoster = new List<Student>();  

        public Course(string courseName, string teacher)
        {
            _courseName = courseName;
            _teacher = teacher;
        }

        public string CourseName { get => _courseName; set => _courseName = value; }
        public string Teacher { get => _teacher; set => _teacher = value; }
        public List<Student> CourseRoster { get => _classRoster;}

        public void EnrollStudent(Student student)
        { 
         _classRoster.Add(student);    
        }
        public double ClassRosterAverage ()
        {
            double sum = 0;
            foreach (Student student in _classRoster)
            {
                sum += student.GradeAverage();
            }
            return sum/_classRoster.Count();
        }
    }
}
