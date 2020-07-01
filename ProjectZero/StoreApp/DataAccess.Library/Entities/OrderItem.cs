using System;
using System.Collections.Generic;

namespace DataAccess.Library.Entities
{
    
    
        public partial class OrderItem
        {
            public OrderItem()
            {
                CustomerOrder = new HashSet<CustomerOrder>();
            }

            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int? Quantity { get; set; }

            public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }
        }
    }
