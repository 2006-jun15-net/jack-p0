using DataAccess.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DataAccess.Library.Repos
{
    public class OrderRepo
    {
        public static readonly String connectionString = "Server=tcp:2020-revature-pflug.database.windows.net,1433;Initial Catalog=projectZero;Persist Security Info=False;User ID=jack;Password= Bluefridge122;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        //System.IO.File.ReadAllText("C:/Revature_Code/secretConnectionString/connection.txt");

        public static readonly Microsoft.EntityFrameworkCore.DbContextOptions<projectZeroContext> Options = new Microsoft.EntityFrameworkCore.DbContextOptionsBuilder<projectZeroContext>()
            .UseSqlServer(connectionString)
            .Options;


        public static void createOrder()
        {
            Console.WriteLine("Whats your Name? Please enter your full name.");
            Console.WriteLine("WARNING: you must be registered in our database to make an order!");
            Console.WriteLine("");
            var userFullName = Console.ReadLine();
            Console.WriteLine("Select a location you would like to order from");
            storeRepo.getStores();
            var userlocation = Console.ReadLine();
            Console.WriteLine("What would you like to order?");
            OrderItemRepo.getOrderItems();
            var orderChoice = Console.ReadLine();

            var newOrder = new CustomerOrder
            {
                CustomerName = userFullName,
                LocationName = userlocation,
                ProductName = orderChoice,
            };

            var context = new projectZeroContext(Options);
            context.Add(newOrder);
            context.SaveChanges();
            Console.WriteLine("Order Recieved");



        }

        public static void displayOrderHistory()
        {
            Console.WriteLine("What name was the order under? Ie. Firstname Lastname");
            var customerName = Console.ReadLine();
            var searchCustomerOrder = new CustomerOrder
            {
                CustomerName = customerName,


            };

            var context = new projectZeroContext(Options);
            foreach (var cOrder in context.CustomerOrders)
            {
                if (searchCustomerOrder.CustomerName.Equals(cOrder.CustomerName))
                {
                    Console.WriteLine($"Order #{cOrder.OrderId}: Customer name{cOrder.CustomerName} Location ordered at: {cOrder.LocationName}, {cOrder.ProductName}");
                }
                else
                {
                    Console.WriteLine("no orders were found under this name.");
                }
            }




        }
        public static void findOrdersAtLocation()
        {
            Console.WriteLine("What store location would you like to search?");
              storeRepo.getStores();

            var searchlocation = Console.ReadLine();
            var searchOrderbyLocation = new CustomerOrder
            {
                LocationName = searchlocation
        };
            var context = new projectZeroContext(Options);
            foreach (var search in context.CustomerOrders) {
                if (searchOrderbyLocation.LocationName.Equals(search.LocationName))
                {
                    Console.WriteLine($"{search.LocationName } orders: OrderId#{search.OrderId} Customer name:{search.CustomerName} "); 
                }
                else
                {
                    Console.WriteLine("no orders were found at this location"); 
                }
                    }
    }



    }

    //gotta collect the customers name, location they're ordering from, and what items they want/in what quantities
    // take userInput and set it to the customers name- do the same for Location 
    // display order items and create way for the users to select the items that they want- maybe create a method where they can keep on adding stuff to their order list and 
    //press a key when they're done 

}

