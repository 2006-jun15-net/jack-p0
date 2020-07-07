using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Library.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Library.Repos
{
    public class OrderItemRepo
    {
        public static readonly String connectionString = 
           
       // System.IO.File.ReadAllText("C:/Revature_Code/secretConnectionString/connection.txt");

        public static readonly DbContextOptions<projectZeroContext> Options = new DbContextOptionsBuilder<projectZeroContext>()
            .UseSqlServer(connectionString)
            .Options;
        public static void getOrderItems()
        {
            var context = new projectZeroContext(Options);
            List<OrderItem> items = context.OrderItem
                .ToList();
            Console.WriteLine("Here's what we got:"); 
            foreach(var item in items)
            {
                Console.WriteLine($"{item.ProductId}) {item.ProductName}"); 
            }

        }
    

}
}
