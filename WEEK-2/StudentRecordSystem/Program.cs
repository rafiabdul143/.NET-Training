using StudentRecordSystem.Models;
using StudentRecordSystem.Services;

namespace StudentRecordSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();

            int choice;

            do
            {
                Console.WriteLine("\n=================================");
                Console.WriteLine(" STUDENT RECORD MANAGEMENT SYSTEM");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.WriteLine("=================================");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter Student ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Department: ");
                        string department = Console.ReadLine();

                        Console.Write("Enter Course: ");
                        string course = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        Console.Write("Enter Phone: ");
                        string phone = Console.ReadLine();

                        Console.Write("Enter Marks: ");
                        double marks = Convert.ToDouble(Console.ReadLine());

                        Student student = new Student(
                            id,
                            name,
                            age,
                            department,
                            course,
                            email,
                            phone,
                            marks
                        );

                        studentService.AddStudent(student);
                        break;

                    case 2:

                        studentService.ViewAllStudents();
                        break;

                    case 3:

                        Console.Write("Enter Student ID: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        Student foundStudent = studentService.SearchStudent(searchId);

                        if (foundStudent != null)
                        {
                            foundStudent.DisplayStudent();
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }

                        break;

                    case 4:

                        Console.Write("Enter Student ID to Update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        studentService.UpdateStudent(updateId);

                        break;

                    case 5:

                        Console.Write("Enter Student ID to Delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        studentService.DeleteStudent(deleteId);

                        break;

                    case 6:

                        Console.WriteLine("Thank you for using the Student Record Management System.");
                        break;

                    default:

                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            } while (choice != 6);
        }
    }
}