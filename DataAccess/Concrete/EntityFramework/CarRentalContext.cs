using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentalContext : DbContext
    {
        //Bu bölüm hangi veri tabanına bağlanacağımızı belirttiğimiz bölümdür
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connectionstring'in başında "@" olmasının sebebi "\" işaretini olduğu gibi algılaması içindir, c#'ta "\" başka bir anlam ifade etmektedir. 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=CarRental; Trusted_Connection=true");
        }

        //Bu bölümde ise hangi entity'nin veri tabanında hangi tabloya bağlanacağı belirlenmektedir.
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
    }
}
