using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Library.Entities
{
    public class CustomerProvider { 
        private readonly projectZeroContext projectzeroContext; 
    
        public CustomerProvider(projectZeroContext projectzeroContext)
        {
            this.projectzeroContext = projectzeroContext; 
        }

        public Customer Get(int id )
        {
           return projectzeroContext.Customer.Where(c => c.CustomerId == id).FirstOrDefault();
        }

    }
}
