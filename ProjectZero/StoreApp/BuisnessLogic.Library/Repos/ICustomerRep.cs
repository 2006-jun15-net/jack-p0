﻿using BusinessLogic.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic.Library.Repos
{
    public interface ICustomerRep : IRepository<Customer>
    {
        void Add(global::DataAccess.Library.Entities.Customer customer);
    }
}
