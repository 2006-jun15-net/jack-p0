using System;
using System.Collections.Generic;

namespace DataAccess.Library.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerOrder = new HashSet<CustomerOrder>();
        }

        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string StoreLocation { get; set; }

        public virtual StoreLocation StoreLocationNavigation { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }
    }
}
