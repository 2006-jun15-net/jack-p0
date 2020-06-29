using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Library.Models
{
    class Customer

    {

        private string _firstname;
        private string _lastname; 
       


        public string FirstName { get => _firstname; set{
            if (value.Length == 0)
                {
                    throw new ArgumentException("The first name must not be empty.", nameof(value));
                    }
                    _firstname = value;
                }

            }

        public string LastName { get => _lastname; 
            set {
                
                if (value.Length == 0)
            {
                throw new ArgumentException("The last name must not be empty.", nameof(value));
            }
            _lastname = value;
            }  
        }


        public string Name { get => FirstName + " " + LastName; }

        public int CustomerId { get; set; }






    }
}
