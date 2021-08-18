using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demiroğ";
            course1.ViewRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Kerem Varış";
            course2.ViewRate = 64;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instructor = "Berkay Bilgin";
            course3.ViewRate = 80;

            Course course4 = new Course();
            course4.CourseName = "C++";
            course4.Instructor = "Murat Kurtboğan";
            course4.ViewRate = 100;


            //Console.WriteLine(course1.CourseName + " : " + course1.Instructor);

            Course[] courses = new Course[] { course1, course2, course3, course4 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Instructor);
            }


            Console.WriteLine();

            Console.ReadLine();
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int ViewRate { get; set; }
    }
}
