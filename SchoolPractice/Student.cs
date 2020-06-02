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

        public void AddGrade(int courseCredits, double grade)
        {
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += (courseCredits * grade);
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }


        public string GetGradeLevel()
        {
            string gradeLevel = "";
            if(NumberOfCredits >= 0 && NumberOfCredits < 30)
            {
                gradeLevel = "Freshman";
            } else if (NumberOfCredits >=30 && NumberOfCredits < 60 )
            {
                gradeLevel = "Sophomore";
            } else if (NumberOfCredits >=60 && NumberOfCredits < 90)
            {
                gradeLevel = "Junior";
            } else if (NumberOfCredits >=90)
            {
                gradeLevel = "Senior";
            }
            return gradeLevel;
        }

        public override string ToString()
        {
            return $"{Name} (Credits: {NumberOfCredits}, GPA: {Gpa})";
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
    }
}
