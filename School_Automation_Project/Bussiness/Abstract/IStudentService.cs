using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void RemoveStudent(int id);
        Student GetStudentById(int id);
        List<Student> GetAllStudents();
        List<Assignment> GetAssigmentsByStudentId(int studentId);
    }
}
