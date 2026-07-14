namespace StudentRecordSystem.Models
{
    public class Student
    {
        // Properties
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Department { get; set; }

        public string Course { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public double Marks { get; set; }

        public char Grade { get; set; }

        // Default Constructor
        public Student()
        {
        }

        // Parameterized Constructor
        public Student(
            int studentId,
            string name,
            int age,
            string department,
            string course,
            string email,
            string phone,
            double marks)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            Department = department;
            Course = course;
            Email = email;
            Phone = phone;
            Marks = marks;

            Grade = CalculateGrade(marks);
        }

        // Method to calculate grade
        private char CalculateGrade(double marks)
        {
            if (marks >= 90)
                return 'A';
            else if (marks >= 80)
                return 'B';
            else if (marks >= 70)
                return 'C';
            else if (marks >= 60)
                return 'D';
            else
                return 'F';
        }

        // Display Student Details
        public void DisplayStudent()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Student ID : {StudentId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Age        : {Age}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"Course     : {Course}");
            Console.WriteLine($"Email      : {Email}");
            Console.WriteLine($"Phone      : {Phone}");
            Console.WriteLine($"Marks      : {Marks}");
            Console.WriteLine($"Grade      : {Grade}");
            Console.WriteLine("---------------------------------------------");
        }
    }
}