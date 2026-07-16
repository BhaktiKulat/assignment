using System;

namespace StudentManagementSystem
{
    class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public int Credits { get; set; }

        public Course(int id, string name, int credits)
        {
            CourseId = id;
            CourseName = name;
            Credits = credits;
        }

        public override string ToString()
        {
            return $"{CourseId} - {CourseName} ({Credits} Credits)";
        }
    }
}