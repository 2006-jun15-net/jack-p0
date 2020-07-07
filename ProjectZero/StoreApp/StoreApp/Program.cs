using BuisnessLogic.Library.Repos;
using BusinessLogic.Library;
using DataAccess.Library.Entities;
using DataAccess.Library.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreApp
{
    class Program
    {

        public static readonly String connectionString = System.IO.File.ReadAllText("secretString");

        public static readonly DbContextOptions<projectZeroContext> Options = new DbContextOptionsBuilder<projectZeroContext>()

          .UseSqlServer(connectionString)

              .Options;


        static void Main(string[] args) {
            //var getCustomerRepo = new CustomerRepo(); 
            while (true)
            {
                Console.WriteLine("Welcome to Downtown Deli!");
                Console.WriteLine("");
                Console.WriteLine("For customer access: a to add a new customer, press d to display customer, press s to search for a Customer");
                Console.WriteLine("For store location info: Press l for store locations, press sl to search for orders at a given location");
                Console.WriteLine("For orders: press c to create order, press do to display a customers order history");
                Console.WriteLine("To exit press q"); 
                Console.WriteLine("");
                var userInput = Console.ReadLine();
                if (userInput == "a")
                {
                    CustomerRepo.addCustomer();


                }

                else if (userInput == "d")
                {
                    CustomerRepo.displayCustomer();
                }



                else if (userInput == "q")
                {
                    break;
                }

                else if (userInput == "r")
                {
                    CustomerRepo.deleteCustomer();
                }
                else if (userInput == "l")
                {
                    storeRepo.getStores();
                }
                else if (userInput == "o")
                {
                    OrderItemRepo.getOrderItems();
                }
                else if (userInput == "s")
                {
                 
                    CustomerRepo.findCustomerbyName(); 
                    
                }
                else if(userInput == "c")
                {
                    OrderRepo.createOrder();
                }
                else if(userInput == "do")
                {
                    OrderRepo.displayOrderHistory(); 
                }
                else if(userInput == "sl")
                {
                    OrderRepo.findOrdersAtLocation();
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }


            }


        }
    }
}


