using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Course> courses = new List<Course>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n========== STUDENT MANAGEMENT SYSTEM ==========");
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Add Course");
                Console.WriteLine("5. View All Courses");
                Console.WriteLine("6. Register Course");
                Console.WriteLine("7. View Student Details");
                Console.WriteLine("8. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterStudent();
                        break;

                    case 2:
                        ViewStudents();
                        break;

                    case 3:
                        SearchStudent();
                        break;

                    case 4:
                        AddCourse();
                        break;

                    case 5:
                        ViewCourses();
                        break;

                    case 6:
                        RegisterCourse();
                        break;

                    case 7:
                        StudentDetails();
                        break;

                    case 8:
                        Console.WriteLine("Thank You!");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }

        static void RegisterStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            Console.WriteLine("\nSelect Student Type");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Scholarship");
            Console.WriteLine("3. Part-Time");

            Console.Write("Enter Choice: ");
            int type = Convert.ToInt32(Console.ReadLine());

            Student s;

            switch (type)
            {
                case 1:
                    s = new RegularStudent(id, name, dept);
                    break;

                case 2:
                    s = new ScholarshipStudent(id, name, dept);
                    break;

                case 3:
                    s = new PartTimeStudent(id, name, dept);
                    break;

                default:
                    Console.WriteLine("Invalid Student Type");
                    return;
            }

            students.Add(s);

            Console.WriteLine("Student Registered Successfully!");
        }

        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n----- Student List -----");

            foreach (Student s in students)
            {
                Console.WriteLine($"{s.StudentId}  {s.StudentName}  {s.Department}  ({s.StudentType()})");
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student s = students.Find(x => x.StudentId == id);

            if (s == null)
            {
                Console.WriteLine("Student Not Found.");
            }
            else
            {
                Console.WriteLine("\nStudent Found");
                Console.WriteLine($"ID : {s.StudentId}");
                Console.WriteLine($"Name : {s.StudentName}");
                Console.WriteLine($"Department : {s.Department}");
                Console.WriteLine($"Type : {s.StudentType()}");
            }
        }

        static void AddCourse()
        {
            Console.Write("Enter Course ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Credits: ");
            int credits = Convert.ToInt32(Console.ReadLine());

            courses.Add(new Course(id, name, credits));

            Console.WriteLine("Course Added Successfully!");
        }

        static void ViewCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No Courses Available.");
                return;
            }

            Console.WriteLine("\n----- Course List -----");

            foreach (Course c in courses)
            {
                Console.WriteLine(c);
            }
        }

        static void RegisterCourse()
        {
            Console.Write("Enter Student ID: ");
            int sid = Convert.ToInt32(Console.ReadLine());

            Student student = students.Find(x => x.StudentId == sid);

            if (student == null)
            {
                Console.WriteLine("Student Not Found.");
                return;
            }

            Console.Write("Enter Course ID: ");
            int cid = Convert.ToInt32(Console.ReadLine());

            Course course = courses.Find(x => x.CourseId == cid);

            if (course == null)
            {
                Console.WriteLine("Course Not Found.");
                return;
            }

            student.RegisterCourse(course);
        }

        static void StudentDetails()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student s = students.Find(x => x.StudentId == id);

            if (s == null)
            {
                Console.WriteLine("Student Not Found.");
                return;
            }

            Console.WriteLine("\n========== STUDENT DETAILS ==========");

            Console.WriteLine($"Student ID : {s.StudentId}");
            Console.WriteLine($"Name       : {s.StudentName}");
            Console.WriteLine($"Department : {s.Department}");
            Console.WriteLine($"Type       : {s.StudentType()}");

            Console.WriteLine("\nEnrolled Courses:");

            if (s.EnrolledCourses.Count == 0)
            {
                Console.WriteLine("No Courses Registered.");
            }
            else
            {
                foreach (Course c in s.EnrolledCourses)
                {
                    Console.WriteLine(c);
                }
            }

            Console.WriteLine($"\nTotal Credits : {s.TotalCredits()}");
            Console.WriteLine($"Total Fee     : ₹{s.CalculateFee()}");
        }
    }
}