using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IAssignmentService
    {
        void AddAssigment(Assignment assigment);
        void RemoveAssigment(Assignment assigment);

        List<Assignment> GetAllAssigmentsByClassroom(Classroom classroom);
        List<Assignment> GetAssigmentsByTeacher(Teacher teacher);
        void AssignAssigmentToStudent(Assignment assigment, Student student);
    }
}
