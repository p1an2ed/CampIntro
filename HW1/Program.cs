using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru: 1 den 10 a kadar yazan bir program yap

            int number = 1;

            while (number<=10)
            {
                Console.WriteLine("Number is {0}",number);
                number++;
            }

            Console.ReadKey(true);
        }
    }
}
