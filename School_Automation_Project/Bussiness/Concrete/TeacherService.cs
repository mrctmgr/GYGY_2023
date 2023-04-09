using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class TeacherService : ITeacherService
    {
        private TeacherRepository _teacherRepository;

        public TeacherService(TeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public TeacherService()
        {
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacherRepository.Add(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            return _teacherRepository.GetAll();
        }

        public List<Assignment> GetAssigmentsByTeacherId(int teacherId)
        {
            var teacher = _teacherRepository.GetById(teacherId);
            return teacher?.Assigments;
        }

        public Teacher GetTeacherByTeacherId(int teacherId)
        {
            return _teacherRepository.GetById(teacherId);
        }

        public List<Classroom>? GetClassroomsByTeacherId(int teacherId)
        {
            var teacher = _teacherRepository.GetById(teacherId);
            return teacher.Classrooms;
        }

        public void AssignClassroomToTeacher(int teacherId, int classroomId)
        {
            var teacher = _teacherRepository.GetById(teacherId);
            if (teacher != null)
            {
                teacher.ClassroomId = classroomId;
                _teacherRepository.Update(teacher);
            }
        }
    }
}
