using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer customer1 = new Customer();

            customer1.Id = 01;
            customer1.Name = "Sefa";
            customer1.LastName = "Ciftci";


            Customer customer2 = new Customer();

            customer2.Id = 02;
            customer2.Name = "Burak";
            customer2.LastName = "Iraz";


            Customer customer3 = new Customer();

            customer3.Id = 03;
            customer3.Name = "Ayse";
            customer3.LastName = "Tetik";


            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var cust in customers)
            {
                Console.WriteLine("Id: " + cust.Id + " Name: "+ cust.Name + " Lastname: "+cust.LastName);

            }

            Console.WriteLine("----------------------------------------");

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);










        }

    }
}
