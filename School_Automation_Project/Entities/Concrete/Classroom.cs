using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Classroom : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public int ClassroomId { get; internal set; }
        public List<Student> Students { get; set; }
        public List<Assignment> Assignments { get; set; }
        public Teacher Teacher { get; set;}
    }
}
