using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        Customer customer = new Customer();

        public void Add(Customer customer)
        {
            Console.WriteLine("Addded");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted");
        }

        public void List( Customer customers)
        {

           
            Console.WriteLine("Listed");
        }



    }
}
