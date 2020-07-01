using System;
using System.Collections.Generic;

namespace DataAccess.Library.Entities
{
    public partial class StoreLocation
    {
        public StoreLocation()
        {
            Customer = new HashSet<Customer>();
            CustomerOrder = new HashSet<CustomerOrder>();
        }

        public string LocationName { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }
    }
}
