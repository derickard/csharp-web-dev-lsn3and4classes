using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string Title { get; set; }
        public Teacher Instructor { get; set; }
        private List<Student> students = new List<Student>();

        public Course(string title, Teacher instructor)
        {
            Title = title;
            Instructor = instructor;
        }

        public void Show()
        {
            Console.WriteLine($"------------------------\nCourse: {Title}\nInstructor: {Instructor.LastName},{Instructor.FirstName}\n------------------------\nStudent Roster\n------------------------\nName\tID\n----\t----");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name}\t{student.StudentId}");
            }
        }

        public void AddStudent(Student newStudent)
        {
            if (!students.Contains(newStudent))
            {
                students.Add(newStudent);
            } else
            {
                Console.WriteLine("Student is already in the class.");
            }
        }

        public void RemoveStudent(Student newStudent)
        {
            if (students.Contains(newStudent))
            {
                students.Remove(newStudent);
            }
            else
            {
                Console.WriteLine("Student is not in the class, cannot remove.");
            }
        }

    }
}
