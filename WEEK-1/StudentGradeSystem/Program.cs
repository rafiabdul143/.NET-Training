using System;

Console.WriteLine("=========================================");
Console.WriteLine("      Student Grading System App        ");
Console.WriteLine("=========================================\n");

// 1. Get the Student's Name
Console.Write("Enter student's name: ");
string studentName = Console.ReadLine();


string maxInput = "100";
double maxMarks = Convert.ToDouble(maxInput);

// 3. Get the Marks Scored by the student
Console.Write($"Enter the marks scored by {studentName}: ");
string scoredInput = Console.ReadLine();
double scoredMarks = Convert.ToDouble(scoredInput);

// 4. Calculate the Final Percentage
double percentage = (scoredMarks / maxMarks) * 100;

// 5. Determine the Letter Grade using simple IF conditions
string letterGrade = "";

if (percentage >= 90)
{
    letterGrade = "A";
}
else if (percentage >= 80)
{
    letterGrade = "B";
}
else if (percentage >= 70)
{
    letterGrade = "C";
}
else if (percentage >= 60)
{
    letterGrade = "D";
}
else
{
    letterGrade = "F";
}

// 6. Display the final Report Card
Console.WriteLine("\n=========================================");
Console.WriteLine("              REPORT CARD                ");
Console.WriteLine("=========================================");
Console.WriteLine($"Student Name:     {studentName}");
Console.WriteLine($"Score Obtained:   {scoredMarks} / {maxMarks}");
Console.WriteLine($"Final Percentage: {percentage}%");
Console.WriteLine($"Grade Awarded:    Grade {letterGrade}");
Console.WriteLine("=========================================");