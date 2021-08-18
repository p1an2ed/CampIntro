using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - kendini tekrarlama!
            //değer tutucu - alias

            string categoryTag = "Category";
            int numberOfStudents = 32000;
            double interestRate = 1.45;
            bool HaveYouLoggedIntoSystem = false;
            double dollarYesterday = 7.35;
            double dollarToday = 7.45;

            Console.WriteLine(categoryTag);

            ////////////////////////////////////////

            if (HaveYouLoggedIntoSystem == true)
            {
                Console.WriteLine("User settings button");
            }
            else
            {
                Console.WriteLine("Login  button");
            }

            ////////////////////////////////////////

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Decrease button");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Increase button");
            }
            else
            {
                Console.WriteLine("Has not changed button");
            }
        }
    }
}
