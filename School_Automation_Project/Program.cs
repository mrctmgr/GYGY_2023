using Entities.Concrete;
using Bussiness.Abstract;
using Bussiness.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Classroom> classrooms = new List<Classroom>();
            List<Teacher> teachers = new List<Teacher>();
            List<Assignment> assignments = new List<Assignment>();

            while (true)
            {
                Console.WriteLine("Welcome to the School-Automation System\n**************************************\n");
                Console.WriteLine("For Classroom\n-----------------\n");
                Console.WriteLine("1) Add Classroom");
                Console.WriteLine("2) List Classrooms");
                Console.WriteLine("3) Get the classroom with ID");
                Console.WriteLine("4) List the students in classroom\n*******************************************\n");

                Console.WriteLine("For Teacher\n---------------------------------");
                Console.WriteLine("5) Search Teacher with ID");
                Console.WriteLine("6) Add Teacher");
                Console.WriteLine("7) List teachers");

                Console.WriteLine("For Assignment\n-------------------------------------\n");
                Console.WriteLine("8) Create Assignment"); ;
                Console.WriteLine("9) List Assignment");
                Console.WriteLine("10) Show Assignment for students\n***********************************************\n");

                Console.WriteLine("For Students\n-----------------------------");
                Console.WriteLine("11) Search students with ID");
                Console.WriteLine("12) List all students");
                Console.WriteLine("13) Add Students");
                Console.WriteLine("0) Exit the program");
                Console.Write("Please Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        // Add Classroom
                        AddClassroom(classrooms, teachers);
                        break;
                    case 2:
                        // List Classrooms
                        ListClassrooms();
                        break;
                    case 3:
                        // Get classroom info with id
                        GetClassroomById(classrooms);
                        break;
                    case 4:
                        // List Students in classroom
                        ListStudentsInClassroom();
                        break;
                    case 5:
                        // Search teacher with id
                        SearchTeacherById(teachers);
                        break;
                    case 6:
                        // Add Teacher
                        AddTeacher(teachers, classrooms);
                        break;
                    case 7:
                        // List Teachers
                        ListTeachers(teachers);
                        break;
                    case 8:
                        // Create Assignment
                        CreateAssignment(classrooms);
                        break;
                    case 9:
                        // Ödevleri listele
                        ListAssignments(assignments);
                        break;
                    case 10:
                        // Show assigments for students
                        ShowAssignmentsForStudents(assignments);
                        break;
                    case 11:
                        // Search students with id
                        SearchStudentById(classrooms);
                        break;
                    case 12:
                        // List all students
                        ListStudents(students);
                        break;
                    case 13:
                        // Add students
                        AddStudent(students,classrooms);
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }



        public static void AddClassroom(List<Classroom> classrooms, List<Teacher> teachers)
        {
            Console.WriteLine("Enter classroom name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter teacher ID:");
            int teacherId = Convert.ToInt32(Console.ReadLine());

            // Check if teacher exists
            Teacher teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
            if (teacher == null)
            {
                Console.WriteLine("Teacher not found.");
                return;
            }

            Classroom newClassroom = new Classroom
            {
                Id = classrooms.Count + 1,
                Name = name,
                TeacherId = teacherId,
                Students = new List<Student>(),
                Teacher = teacher
            };
            classrooms.Add(newClassroom);

            Console.WriteLine($"Classroom \"{newClassroom.Name}\" with ID \"{newClassroom.Id}\" added successfully.");
        }

        public static void ListClassrooms(ClassroomService classroomService)
        {
            Console.WriteLine("Classrooms:");
            Console.WriteLine("------------------------------------------------------");

            var classrooms = classroomService.GetAllClassrooms();

            foreach (var classroom in classrooms)
            {
                Console.WriteLine($"ID: {classroom.Id} - Name: {classroom.Name} - Teacher: {classroom.Teacher.Name} {classroom.Teacher.Surname}");
            }

            Console.WriteLine("------------------------------------------------------");
        }

        public static Classroom GetClassroomById(List<Classroom> classrooms)
        {
            Console.WriteLine("Enter the classroom ID: ");
            int id = int.Parse(Console.ReadLine());
            var classroom = classrooms.FirstOrDefault(c => c.Id == id);

            if (classroom != null)
            {
                return classroom;
            }
            else
            {
                return null;
            }
        }

        public static void ListStudentsInClassroom(ClassroomService classroomService)
        {
            Console.WriteLine("Enter the classroom ID: ");
            int classroomId = int.Parse(Console.ReadLine());

            Classroom classroom = classroomService.GetClassroomById(classroomId);

            if (classroom != null)
            {
                Console.WriteLine($"Students in {classroom.Name} classroom: ");
                foreach (var student in classroom.Students)
                {
                    Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name} {student.Surname}");
                }
            }
            else
            {
                Console.WriteLine("Classroom not found!");
            }
        }
        private static void SearchTeacherById(int teacherId)
        {
            throw new NotImplementedException();
        }

        public void SearchTeacherById(TeacherService teacherService)
        {
            Console.WriteLine("Enter the ID of the teacher you want to search:");
            int id = int.Parse(Console.ReadLine());

            var teacher = teacherService.GetTeacherByTeacherId(id);

            if (teacher != null)
            {
                Console.WriteLine($"Name: {teacher.Name} {teacher.Surname}, Age : {teacher.Age}");
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }

        public static void AddTeacher(List<Teacher> teachers, List<Classroom> classrooms)
        {
            Console.Write("Enter the name of the teacher: ");
            string name = Console.ReadLine();

            Console.Write("Enter the surname of the teacher: ");
            string surname = Console.ReadLine();

            Console.Write("Enter the age of the teacher: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("List of classrooms: ");
            ListClassrooms();

            Console.Write("Enter the ID of the classroom which the teacher will be assigned to: ");
            int classroomId = Convert.ToInt32(Console.ReadLine());

            Teacher newTeacher = new Teacher
            {
                Id = teachers.Count + 1,
                Name = name,
                Surname = surname,
                Age = age,
                ClassroomId = classroomId,
                Classrooms = new List<Classroom>(),
                Assigments = new List<Assignment>()
            };

            teachers.Add(newTeacher);
            
            Classroom classroom = classrooms.FirstOrDefault(c => c.Id == classroomId);
            classroom.Teacher = newTeacher;
            classroom.TeacherId = newTeacher.Id;

            Console.WriteLine("Teacher added successfully.");
        }
        
        private static void ListStudentsInClassroom()
        {
            throw new NotImplementedException();
        }


        public static void ListTeachers(List<Teacher> teachers)
        {
            Console.WriteLine("List of Teachers\n");
            Console.WriteLine("ID\tName\tSurname\tAge\tClassroom\n");

            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"{teacher.Id}\t{teacher.Name}\t{teacher.Surname}\t{teacher.Age}\t{teacher.ClassroomId}");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void CreateAssignment(List<Classroom> classrooms, List<Assignment> assignments)
        {
            Console.WriteLine("Creating a new assignment...");
            Console.Write("Enter the assignment title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the assignment description: ");
            string description = Console.ReadLine();

            Console.Write("Enter the deadline (yyyy-mm-dd hh:mm:ss): ");
            DateTime deadline = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the classroom ID: ");
            int classroomId = int.Parse(Console.ReadLine());

            Classroom classroom = classrooms.FirstOrDefault(c => c.Id == classroomId);
            if (classroom == null)
            {
                Console.WriteLine($"Classroom with ID {classroomId} not found.");
                return;
            }

            Console.Write("Enter the teacher ID: ");
            int teacherId = int.Parse(Console.ReadLine());

            Teacher teacher = classroom.Teacher;
            if (teacher.Id != teacherId)
            {
                Console.WriteLine($"Teacher with ID {teacherId} is not assigned to classroom with ID {classroomId}.");
                return;
            }

            Assignment assignment = new Assignment()
            {
                Id = assignments.Count + 1,
                Title = title,
                Description = description,
                Deadline = deadline,
                Classroom = classroom,
                Teacher = teacher
            };

            assignments.Add(assignment);

            Console.WriteLine("Assignment created successfully!");
        }



        private static void ListTeachers()
        {
            throw new NotImplementedException();
        }

        public static void CreateAssignment(List<Classroom> classrooms)
        {
            Console.Write("Enter the assignment title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the assignment description: ");
            string description = Console.ReadLine();

            Console.Write("Enter the assignment deadline (mm/dd/yyyy): ");
            DateTime deadline = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the ID of the classroom for the assignment: ");
            int classroomId = int.Parse(Console.ReadLine());

            var classroom = classrooms.FirstOrDefault(c => c.Id == classroomId);

            if (classroom != null)
            {
                Console.Write("Enter the ID of the teacher for the assignment: ");
                int teacherId = int.Parse(Console.ReadLine());

                var teacher = classroom.Teacher;

                if (teacher.Id == teacherId)
                {
                    Assignment newAssignment = new Assignment()
                    {
                        Title = title,
                        Description = description,
                        Deadline = deadline,
                        Classroom = classroom,
                        Teacher = teacher
                    };

                    Console.WriteLine("Enter the ID of the students to assign the assignment to (separated by commas):");
                    string studentIdsInput = Console.ReadLine();
                    string[] studentIds = studentIdsInput.Split(',');

                    foreach (string studentId in studentIds)
                    {
                        int id = int.Parse(studentId);
                        var student = classroom.Students.FirstOrDefault(s => s.Id == id);

                        if (student != null)
                        {
                            newAssignment.AssignToStudent(student);
                        }
                    }

                    classroom.Assignments.Add(newAssignment);

                    Console.WriteLine("Assignment created successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid teacher ID!");
                }
            }
            else
            {
                Console.WriteLine("Classroom not found!");
            }
        }

        public static void ListAssignments(List<Assignment> assignments)
        {
            Console.WriteLine("Assignments:");
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"ID: {assignment.Id}");
                Console.WriteLine($"Title: {assignment.Title}");
                Console.WriteLine($"Description: {assignment.Description}");
                Console.WriteLine($"Deadline: {assignment.Deadline}");
                Console.WriteLine($"Classroom: {assignment.Classroom.Name}");
                Console.WriteLine($"Teacher: {assignment.Teacher.Name}");
                Console.WriteLine("Assigned Students:");
                foreach (var student in assignment.AssignedStudents)
                {
                    Console.WriteLine($"{student.Id} - {student.Name} {student.Surname}");
                }
                Console.WriteLine("----------------------");
            }
        }

        public static void ShowAssignmentsForStudents(List<Assignment> assignments)
        {
            Console.Write("Enter the student ID: ");
            int id = int.Parse(Console.ReadLine());

            var studentAssignments = assignments.Where(a => a.AssignedStudents.Any(s => s.Id == id)).ToList();

            if (studentAssignments.Any())
            {
                Console.WriteLine($"Assignments for student with ID {id}:");
                foreach (var assignment in studentAssignments)
                {
                    Console.WriteLine($"Title: {assignment.Title}");
                    Console.WriteLine($"Description: {assignment.Description}");
                    Console.WriteLine($"Deadline: {assignment.Deadline}");
                    Console.WriteLine($"Assigned Teacher: {assignment.Teacher.Name}");
                    Console.WriteLine($"Assigned Classroom: {assignment.Classroom.Name}");
                    Console.WriteLine($"Completed: {assignment.IsCompleted}");
                    Console.WriteLine("--------------------------");
                }
            }
            else
            {
                Console.WriteLine("No assignments found for student with ID {id}");
            }
        }

        public static Student SearchStudentById(List<Classroom> classrooms)
        {
            Console.WriteLine("Enter the Student's ID: ");
            int id = int.Parse(Console.ReadLine());
            foreach (var classroom in classrooms)
            {
                var student = classroom.Students.FirstOrDefault(s => s.Id == id);

                if (student != null)
                {
                    return student;
                }
            }

            return null;
        }

        public static void ListStudents(List<Student> students)
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id} - {student.Name} {student.Surname} - Age: {student.Age} - Classroom: {student.Classroom}");
            }
        }

        public static void AddStudent(List<Student> students, List<Classroom> classrooms)
        {
            Console.WriteLine("Enter student information:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Classroom ID: ");
            int classroomId = int.Parse(Console.ReadLine());

            var classroom = classrooms.FirstOrDefault(c => c.Id == classroomId);
            if (classroom == null)
            {
                Console.WriteLine("Classroom not found!");
                return;
            }

            var student = new Student()
            {
                Id = students.Count + 1,
                Name = name,
                Surname = surname,
                Age = age,
                Classroom = classroom.Name
            };

            students.Add(student);
            classroom.Students.Add(student);
            Console.WriteLine("Student added successfully!");
        }

        public static Teacher SearchTeacherById(List<Teacher> teachers)
        {
            Console.WriteLine("Enter the teacher's ID: ");
            int id = int.Parse(Console.ReadLine());
            var teacher = teachers.FirstOrDefault(t => t.Id == id);

            if (teacher != null)
            {
                Console.WriteLine($"Teacher ID: {teacher.Id}");
                Console.WriteLine($"Teacher Name: {teacher.Name}");
                Console.WriteLine($"Teacher Surname: {teacher.Surname}");
                Console.WriteLine($"Teacher Age: {teacher.Age}");
                Console.WriteLine($"Assigned Classroom: {teacher.Classrooms.FirstOrDefault().Name}");
                return teacher;
            }
            else
            {
                Console.WriteLine("Teacher not found!");
                return null;
            }
        }
    }
}
