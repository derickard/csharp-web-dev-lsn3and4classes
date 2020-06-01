using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student (string name, int studentID, int numCredits, double gpa)
        {
            Name = name;
            StudentId = studentID;
            NumberOfCredits = numCredits;
            Gpa = gpa;
        }

        public void Show()
        {
            Console.WriteLine($"Student Status: {Name} (ID:{StudentId}) has {NumberOfCredits} credits and a {Gpa} GPA");
        }
    }
}
