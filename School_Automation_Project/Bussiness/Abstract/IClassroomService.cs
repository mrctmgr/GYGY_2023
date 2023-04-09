using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IClassroomService
    {
        void AddClassroom(Classroom classroom);
        void RemoveClassroom(int id);
        void UpdateClassroom(int id, Classroom classroom);
        List<Classroom> GetAllClassrooms();
        Classroom GetClassroomById(int id);
    }
}
