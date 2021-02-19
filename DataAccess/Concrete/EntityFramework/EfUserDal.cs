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
    public class EfUserDal : IUserDal
    {
        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                return filter == null ? context.Set<User>().ToList() : context.Set<User>().Where(filter).ToList();
            }
        }

        public User Get(Expression<Func<User, bool>> filter = null)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }

        public void Add(User entity)
        {
            using (CarRentalContext context =new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(User entity)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
