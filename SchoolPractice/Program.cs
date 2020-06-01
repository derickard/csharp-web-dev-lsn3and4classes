using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student myStudent = new Student("bob", 12345, 1, 4.0);
            myStudent.Show();

            Teacher myTeacher = new Teacher("Moe", "Alali", "web dev", 5.5);
            myTeacher.Show();

            Course myCourse = new Course("LC101", myTeacher);

            myCourse.AddStudent(myStudent);

            myCourse.Show();
        }
    }
}
