using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students;

        public StudentService()
        {
            _students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public List<Assignment> GetAssigmentsByStudentId(int studentId)
        {
            List<Assignment> assignments = new List<Assignment>();

            foreach (Student student in _students)
            {
                if (student.Id == studentId)
                {
                    assignments = student.Assigments;
                    break;
                }
            }

            return assignments;
        }

        public Student GetStudentById(int id)
        {
            return _students.FirstOrDefault(student => student.Id == id);
        }

        public void RemoveStudent(int id)
        {
            Student studentToRemove = _students.FirstOrDefault(s => s.Id == id);
            if (studentToRemove != null)
            {
                _students.Remove(studentToRemove);
            }
        }
    }
}
