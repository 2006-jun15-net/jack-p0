using BuisnessLogic.Library.Repos;
using DataAccess.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Library.Repos
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly projectZeroContext _context; 

        public UnitOfWork(projectZeroContext context)
        {
            _context = context;
            //Customers = new CustomerRepo(_context);


        }

        public ICustomerRep Customers { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
             _context.Dispose(); 
        }
    }
}
