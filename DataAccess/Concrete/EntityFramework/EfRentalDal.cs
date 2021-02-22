using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join m in context.Customers on r.CustomerId equals m.CustomerId
                             join u in context.Users on m.UserId equals u.UserId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join n in context.Colors on c.ColorId equals n.ColorId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 Color = n.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 CustomerId = m.CustomerId,
                                 CustomerFirstName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 CompanyName = m.CompanyName,
                                 Email = u.Email,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
