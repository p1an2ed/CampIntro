using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Software Developer Training Camp";
            string course2 = "Basic Course for Beginner Programming";
            string course3 = "Java";
            string course4 = "Python";
            string course5 = "C++";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            Console.WriteLine(course5);

            Console.WriteLine("----------------End of Basic Strings----------------");
            //Array - Dizi

            string[] courses = new string[] { "Software Developer Training Camp", "Basic Course for Beginner Programming", "Java", "Python", "C++" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("----------------End of For Loop----------------");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("----------------End of Foreach Loop----------------");

            Console.WriteLine("End of Page - footer");

            Console.ReadLine();
        }
    }
}
