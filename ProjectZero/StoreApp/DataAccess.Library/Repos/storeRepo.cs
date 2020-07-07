using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Library.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Library.Repos
{
    public class storeRepo
    {
        public static readonly String connectionString = 
        //System.IO.File.ReadAllText("C:/Revature_Code/secretConnectionString/connection.txt");

        public static readonly DbContextOptions<projectZeroContext> Options = new DbContextOptionsBuilder<projectZeroContext>()
            .UseSqlServer(connectionString)
            .Options;

        public static void getStores()
        {
            var context = new projectZeroContext(Options);
            List<StoreLocation> stores = context.StoreLocation
                .ToList();
            foreach (var store in stores)
            {
                Console.WriteLine($"Location: {store.LocationName } ,");
            }


        }




    }
}
