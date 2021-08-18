using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName+ " "+ customer.LastName+" adlı müşteri sisteme eklendi!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı müşteri sistemden silindi!");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı müşteri listelendi!");
        }
    }
}