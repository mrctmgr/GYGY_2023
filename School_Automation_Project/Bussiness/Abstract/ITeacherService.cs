using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ITeacherService
    {
        void AddTeacher(Teacher teacher);
        List<Teacher> GetTeachers();
        public List<Assignment> GetAssigmentsByTeacherId(int teacherId);
        public Teacher GetTeacherByTeacherId(int teacherId);
        public List<Classroom> GetClassroomsByTeacherId(int teacherId);
        void AssignClassroomToTeacher(int teacherId, int classroomId);
    }
}
