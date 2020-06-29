using BuisnessLogic.Library.Repos;
using DataAccess.Library.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using DataAccess.Library.Repos;
using System.Net.Http.Headers;

namespace StoreApp
{
    class Program
    {
        static void Main(string[] args) {





            using (var unitofWork = new UnitOfWork(new projectZeroContext()))
            {
                var customer = new Customer { FirstName = "Jack", LastName = "Pflug" }; 
                unitofWork.Customers.Add(customer);
                unitofWork.Complete();



            }



        }
    }
}


