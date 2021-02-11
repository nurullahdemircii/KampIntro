using System;

namespace L003_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = "Nurullah";
            // int age = 30;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.TeacherName = "Engin Demiroğ";
            course1.ViewRate = 68;

            Course course2 = new Course(); ;
            course2.CourseName = "Java";
            course2.TeacherName = "Kerem Varış";
            course2.ViewRate = 64;

            Course course3 = new Course(); ;
            course3.CourseName = "Python";
            course3.TeacherName = "Berkay Bilgin";
            course3.ViewRate = 60;

            Course course4 = new Course(); ;
            course4.CourseName = "React JS";
            course4.TeacherName = "Nurullah Demirci";
            course4.ViewRate = 61;

            //Console.WriteLine(course1.CourseName + " : " + course1.TeacherName);

            Course[] courses = new Course[] { course1, course2, course3 };
            foreach (Course item in courses)
            {
                Console.WriteLine(item.CourseName + " : " + item.TeacherName);
            }

            Console.ReadLine();
        }
        class Course
        {
            public string CourseName { get; set; }
            public string TeacherName { get; set; }
            public int ViewRate { get; set; }
        }
    }
}
