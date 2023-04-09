using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ClassroomService : IClassroomService
    {
        private readonly List<Classroom> _classrooms;
        private readonly List<Teacher> _teachers;

        public ClassroomService()
        {
            _classrooms = new List<Classroom>();
        }
        public void AddClassroom(Classroom classroom)
        {
            _classrooms.Add(classroom);
        }

        public List<Classroom> GetAllClassrooms()
        {
            return _classrooms;
        }

        public Classroom GetClassroomById(int id)
        {
            return _classrooms.FirstOrDefault(c => c.Id == id);
        }

        public void RemoveClassroom(int id)
        {
            Classroom classroomToRemove = _classrooms.FirstOrDefault(c => c.Id == id);

            if (classroomToRemove == null)
            {
                Console.WriteLine($"Classroom with ID {id} not found.");
            }
            else
            {
                _classrooms.Remove(classroomToRemove);
                Console.WriteLine($"Classroom with ID {id} removed.");
            }
        }

        public void UpdateClassroom(int id, Classroom classroom)
        {
            Classroom classroomToUpdate = _classrooms.FirstOrDefault(c => c.Id == id);

            if (classroomToUpdate == null)
            {
                Console.WriteLine($"Classroom with ID {id} not found.");
            }
            else
            {
                classroomToUpdate.Name = classroom.Name;
                Console.WriteLine($"Classroom with ID {id} updated.");
            }
        }

        public void AssignTeacherToClassroom(int teacherId, int classroomId)
        {
            Classroom classroom = _classrooms.FirstOrDefault(c => c.Id == classroomId);
            Teacher teacher = _teachers.FirstOrDefault(t => t.Id == teacherId);

            if (classroom == null || teacher == null)
            {
                throw new InvalidOperationException("Classroom or teacher not found.");
            }

            if (classroom.TeacherId != null)
            {
                throw new InvalidOperationException("This classroom already has a teacher.");
            }

            classroom.TeacherId = teacherId;
            teacher.ClassroomId = classroomId;

            Console.WriteLine("Teacher {0} assigned to classroom {1}.", teacher.Name, classroom.Name);
        }

    }
}
