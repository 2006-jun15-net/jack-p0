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
            "Server=tcp:2020-revature-pflug.database.windows.net,1433;Initial Catalog=projectZero;Persist Security Info=False;User ID=jack;Password= Bluefridge122;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
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
