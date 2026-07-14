using StudentRecordSystem.Models;

namespace StudentRecordSystem.Services
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();

        // Add Student
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        // View All Students
        public void ViewAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n----- Student List -----");

            foreach (Student student in students)
            {
                student.DisplayStudent();
            }
        }

        // Search Student by ID
        public Student SearchStudent(int studentId)
        {
            foreach (Student student in students)
            {
                if (student.StudentId == studentId)
                {
                    return student;
                }
            }

            return null;
        }

        // Update Student
        public void UpdateStudent(int studentId)
        {
            Student student = SearchStudent(studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter New Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter New Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter New Department: ");
            student.Department = Console.ReadLine();

            Console.Write("Enter New Course: ");
            student.Course = Console.ReadLine();

            Console.Write("Enter New Email: ");
            student.Email = Console.ReadLine();

            Console.Write("Enter New Phone: ");
            student.Phone = Console.ReadLine();

            Console.Write("Enter New Marks: ");
            student.Marks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Student updated successfully.");
        }

        // Delete Student
        public void DeleteStudent(int studentId)
        {
            Student student = SearchStudent(studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            students.Remove(student);

            Console.WriteLine("Student deleted successfully.");
        }
    }
}