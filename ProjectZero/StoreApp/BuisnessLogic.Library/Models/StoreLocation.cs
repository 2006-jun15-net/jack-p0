using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic.Library.Models
{
    class StoreLocation
    {
        private string _locationName;

        public string LocationName
        {
            get => _locationName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("The Store must have a name.", nameof(value));
                }
                _locationName = value;
            }
        }
    }
}
