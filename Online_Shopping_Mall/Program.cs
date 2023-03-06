using System;
using System.Threading;

namespace Online_Shopping_Mall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Online Shopping Mall!! \n");
            Console.WriteLine("Enter customer details:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Customer customer = new Customer(firstName, lastName, address, phoneNumber, email);

            


        }
    }
}