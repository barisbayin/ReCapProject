using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                return filter == null
                    ? context.Set<Customer>().ToList()
                    : context.Set<Customer>().Where(filter).ToList();
            }
        }

        public Customer Get(Expression<Func<Customer, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Customer>().SingleOrDefault(filter);
            }
        }

        public void Add(Customer entity)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Customer entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Customer entity)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
