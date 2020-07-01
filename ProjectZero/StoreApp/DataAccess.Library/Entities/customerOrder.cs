using System;
using System.Collections.Generic;

namespace DataAccess.Library.Entities
{
    public partial class CustomerOrder
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string LocationName { get; set; }
        public string CustomerName { get; set; }

        public virtual Customer CustomerNameNavigation { get; set; }
        public virtual StoreLocation LocationNameNavigation { get; set; }
        public virtual OrderItem ProductNameNavigation { get; set; }
    }
}
