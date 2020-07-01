using BuisnessLogic.Library.Repos;
using DataAccess.Library.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Library.Repos
{
    public class CustomerRepo
    {
        public static readonly String connectionString = "Server=tcp:2020-revature-pflug.database.windows.net,1433;Initial Catalog=projectZero;Persist Security Info=False;User ID=jack;Password= Bluefridge122;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        //System.IO.File.ReadAllText("C:/Revature_Code/secretConnectionString/connection.txt");

        public static readonly DbContextOptions<projectZeroContext> Options = new DbContextOptionsBuilder<projectZeroContext>()
            .UseSqlServer(connectionString)
            .Options;

        public static void displayCustomer()
        {
            var getCustomer = new projectZeroContext(Options);
            List<Customer> customers = getCustomer.Customer
                .ToList();

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer: {customer.FullName}");
            }
        }


        public static void addCustomer()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Whats your Name? Please enter your full name.");
                    var userFullName = Console.ReadLine();
                    //Console.WriteLine("What's your lastname?");
                    //var userLastName = Console.ReadLine();

                    var newCustomer = new Customer
                    {

                        FullName = userFullName,
                        //LastName = userLastName,

                    };

                    var context = new projectZeroContext(Options);
                    //Input validation
                    if (userFullName.Length == 0)
                    {
                        throw new Exception("the name must not be empty");

                    }
                    else
                    {
                        context.Add(newCustomer);
                        context.SaveChanges();
                        break;
                    }
                }
                catch (FormatException e)

                {
                    Console.WriteLine("Please enter a name");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

            }
        }


        public static void deleteCustomer()
        {
            Console.WriteLine("You've selected to remove a customer");
            displayCustomer();
            Console.WriteLine("Which one would you like to remove? Select the person by their id number");
            var userChoice = Console.ReadLine();
            short number;
            var userchoice = Int16.TryParse(userChoice, out number);

            var context = new projectZeroContext(Options);
            var deletedcustomer = context.Customer.Find(userchoice);
            context.Customer.Remove(deletedcustomer);

            Console.WriteLine("Customer deleted!");

        }


        public static void findCustomerbyName()
        {
            var context = new projectZeroContext(Options);
            //var customer = context.Customer.Find(0,"Jack Pflug");
            Console.WriteLine("What is the customers full name? ie. Firstname Lastname");
            var customerName = Console.ReadLine();
            var searchcustomer = new Customer
            {
                FullName = customerName
            };
            foreach (var customer in context.Customer)
            {
                if (searchcustomer.FullName.Equals(customer.FullName))
                {
                    Console.WriteLine($"{customer.FullName} is in our database!");
                }

                else
                {

                }

            }




        }
    }
}
    





