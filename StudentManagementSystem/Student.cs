using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
    class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string Department { get; set; }

        public List<Course> EnrolledCourses = new List<Course>();

        public const int MAX_COURSES = 5;

        public Student(int id, string name, string dept)
        {
            StudentId = id;
            StudentName = name;
            Department = dept;
        }

        public bool RegisterCourse(Course course)
        {
            if (EnrolledCourses.Count >= MAX_COURSES)
            {
                Console.WriteLine("Maximum course limit reached.");
                return false;
            }

            if (EnrolledCourses.Any(c => c.CourseId == course.CourseId))
            {
                Console.WriteLine("Course already registered.");
                return false;
            }

            EnrolledCourses.Add(course);
            Console.WriteLine("Course Registered Successfully.");
            return true;
        }

        public int TotalCredits()
        {
            return EnrolledCourses.Sum(c => c.Credits);
        }

        public virtual double CalculateFee()
        {
            return TotalCredits() * 1000;
        }

        public virtual string StudentType()
        {
            return "Regular";
        }
    }
}
