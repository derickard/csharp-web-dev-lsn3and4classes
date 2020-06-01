using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public double YearsTeaching { get; set; }

        public Teacher(string firstName, string lastName, string subject, double years)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = years;
        }

        public void Show()
        {
            Console.WriteLine($"Teacher Status: {LastName}, {FirstName} has {YearsTeaching} years experience teaching {Subject}");


        }
    }
}
