using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class AssignmentService : IAssignmentService
    {
        private readonly List<Assignment> _assigments;

        public AssignmentService()
        {
            _assigments = new List<Assignment>();
        }

        public void AddAssigment(Assignment assigment)
        {
            _assigments.Add(assigment);
        }

        public void RemoveAssigment(Assignment assigment)
        {
            _assigments.Remove(assigment);
        }

        public List<Assignment> GetAllAssigmentsByClassroom(Classroom classroom)
        {
            List<Assignment> assigments = new List<Assignment>();

            foreach (Assignment assigment in _assigments)
            {
                if (assigment.Classroom == classroom)
                {
                    assigments.Add(assigment);
                }
            }

            return assigments;
        }

        public List<Assignment> GetAssigmentsByTeacher(Teacher teacher)
        {
            List<Assignment> assigments = new List<Assignment>();

            foreach (Assignment assigment in _assigments)
            {
                if (assigment.Teacher == teacher)
                {
                    assigments.Add(assigment);
                }
            }

            return assigments;
        }

        public void AssignAssigmentToStudent(Assignment assigment, Student student)
        {
            if (assigment.AssignedStudents.Contains(student))
            {
                Console.WriteLine("This student already has this assigment!");
            }
            else
            {
                assigment.AssignedStudents.Add(student);
                Console.WriteLine($"Assigment \"{assigment.Title}\" assigned to student \"{student.Name}\"");
            }
        }
    }
}
