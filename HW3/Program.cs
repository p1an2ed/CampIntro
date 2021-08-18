using System;
using System.Collections.Generic;
using System.Linq;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> People = new Dictionary<string, int>();

            People.Add("Yusuf", 16);
            People.Add("Berat", 16);
            People.Add("Zeynep", 20);
            People.Add("Eren", 18);
            People.Add("Selam", 19);
            People.Add("Kişi", 20);
            People.Add("Şahıs", 90);
            People.Add("Try", 120);

            foreach (var person in People)
            {
                Console.WriteLine(person);
            }

            var staff = People.Count();
            Console.WriteLine();
            Console.WriteLine("Eleman sayısı " + staff);

            People.Remove("Zeynep");
            Console.WriteLine();
            foreach (var person in People)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}
