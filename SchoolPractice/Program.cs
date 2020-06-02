using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student myStudent = new Student("bob", 12345, 1, 4.0);
            Console.WriteLine(myStudent.ToString());

            Teacher myTeacher = new Teacher("Moe", "Alali", "web dev", 5.5);
            Teacher myNewTeacher = new Teacher("Bob", "John", "web dev", 1);
            Console.WriteLine(myTeacher.ToString());
            Console.WriteLine(myNewTeacher.ToString());

            Course myCourse = new Course("LC101", myTeacher);

            myCourse.AddStudent(myStudent);

            Console.WriteLine(myCourse.ToString());

            myStudent.AddGrade(4, 3.98);
            Console.WriteLine(myStudent.Gpa);
            Console.WriteLine(myStudent.GetGradeLevel());
        }
    }
}
