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
    public class EfRentalDal : IRentalDal
    {
        public List<Rental> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                return filter == null ? context.Set<Rental>().ToList() : context.Set<Rental>().Where(filter).ToList();
            }
            
        }

        public Rental Get(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Rental>().SingleOrDefault(filter);
            }
        }

        public void Add(Rental entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Rental entity)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Rental entity)
        {
            using (CarRentalContext context= new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
