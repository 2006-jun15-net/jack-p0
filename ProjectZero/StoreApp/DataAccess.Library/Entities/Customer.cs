using System;
using System.Collections.Generic;

namespace DataAccess.Library.Entities
{
    public partial class Customer
    {


        public Customer()
        {
            Customers = new HashSet<Customer>();
        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
