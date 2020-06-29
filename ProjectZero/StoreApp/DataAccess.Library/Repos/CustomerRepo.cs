using BuisnessLogic.Library.Repos;
using DataAccess.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Library.Repos
{
    public class CustomerRepo : GenericRepo<Customer>, ICustomerRep
    {

        public CustomerRepo (projectZeroContext context) : base (context)
        {

        }

        public projectZeroContext projectZeroContext
        {
            get { return Context as projectZeroContext; }
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }


        Customer IRepository<Customer>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customer> IRepository<Customer>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
