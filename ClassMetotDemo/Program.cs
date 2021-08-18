using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Eren", LastName = "Akbaba", City = "İzmir" };

            Customer customer2 = new Customer() { Id = 2, FirstName = "Esma", LastName = "Selim", City = "İstanbul" };

            Customer customer3 = new Customer() { Id = 3, FirstName = "Derin", LastName = "Deniz", City = "Eskişehir" };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);

            Console.ReadLine();
        }
    }
}
