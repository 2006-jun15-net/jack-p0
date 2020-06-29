using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Library
{
    class OrderItem
    {
        //orders should have a product name, should there be a preset list of products for sale? orders should also have a 
        //inventory quantity associated with them... 


        private int _itemCount;
        public string productName { get ; set; }
        
        public int itemCount { get => _itemCount; set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The inventory count for this item is ${value}. Please choose another product for purchase.",
                        nameof(value));
                }
                _itemCount = value;
            }
        }









    }
}
