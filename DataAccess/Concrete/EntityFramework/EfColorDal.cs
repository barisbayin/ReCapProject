using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public void Add(Color entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Color entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
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
