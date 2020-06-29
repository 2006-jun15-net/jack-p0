using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic.Library.Repos
{
    public interface IUnitOfWork : IDisposable
    {


        ICustomerRep Customers { get; }
        int Complete(); 


    }
}
