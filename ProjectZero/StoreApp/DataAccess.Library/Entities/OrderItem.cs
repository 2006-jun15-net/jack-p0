using System;
using System.Collections.Generic;

namespace DataAccess.Library.Entities
{
    public partial class OrderItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
    }
}
