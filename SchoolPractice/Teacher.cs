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

        public override string ToString()
        {
            return $"{FirstName} {LastName} has {YearsTeaching} year{(YearsTeaching > 1 ? "s" : "")} experience teaching {Subject}";
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher teacher &&
                   FirstName == teacher.FirstName &&
                   LastName == teacher.LastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }
}
