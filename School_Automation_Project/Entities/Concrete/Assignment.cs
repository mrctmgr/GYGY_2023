using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Assignment
    {
        private int deadline;
        private Classroom classroom1;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Classroom Classroom { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> AssignedStudents { get; set; }
        public bool IsCompleted { get; set; }
        public int ClassroomId { get; internal set; }
        public object Submissions { get; internal set; }

        public Assignment(int id, string title, string description, DateTime deadline, Classroom classroom, Teacher teacher)
        {
            Id = id;
            Title = title;
            Description = description;
            Deadline = deadline;
            Classroom = classroom;
            Teacher = teacher;
            AssignedStudents = new List<Student>();
        }

        public Assignment(int id, string title, string description, int deadline, Classroom classroom1)
        {
            Id = id;
            Title = title;
            Description = description;
            this.deadline = deadline;
            this.classroom1 = classroom1;
        }

        public Assignment() { }

        public void AssignToStudent(Student student)
        {
            AssignedStudents.Add(student);
        }
    }
}
