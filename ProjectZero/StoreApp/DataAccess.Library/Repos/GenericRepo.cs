using DataAccess.Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Library.Repos
{
   //public class GenericRepo<TEntity> : BuisnessLogic.Library.Repos.IRepository<TEntity> where TEntity : class
   // {


    //    public static readonly String connectionString = System.IO.File.ReadAllText("C:/Users/jack/Desktop/secretConnectionString/connect.txt");

    //    public static readonly DbContextOptions<projectZeroContext> Options = new DbContextOptionsBuilder<projectZeroContext>()

    //      .UseSqlServer(connectionString)

    //          .Options;

        

    //    public static GenericRepo(DbContext context)
    //    {
    //        Options = context;
    //    }

    //    public TEntity Get(int id)
    //    {
          
    //        return Context.Set<TEntity>().Find(id);
    //    }

    //    public IEnumerable<TEntity> GetAll()
    //    {
           
    //        return Context.Set<TEntity>().ToList();
    //    }

    //    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    //    {
    //        return Context.Set<TEntity>().Where(predicate);
    //    }

       

    //    public void Add(TEntity entity)
    //    {
    //        Context.Set<TEntity>().Add(entity);
    //    }

    //    public void AddRange(IEnumerable<TEntity> entities)
    //    {
    //        Context.Set<TEntity>().AddRange(entities);
    //    }

    //    public void Remove(TEntity entity)
    //    {
    //        Context.Set<TEntity>().Remove(entity);
    //    }

    //    public void RemoveRange(IEnumerable<TEntity> entities)
    //    {
    //        Context.Set<TEntity>().RemoveRange(entities);
    //    }

        

        
    //}
}

