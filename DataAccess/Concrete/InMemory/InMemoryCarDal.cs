using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            //Burada sanki veritabanından veri geliyormuş gibi simüle ediyoruz.
            _cars = new List<Car>
            {
                new Car{CarId = 1, ColorId = 1, BrandId =1, ModelYear =2020, DailyPrice = 150, Description = "Dizel araç"},
                new Car{CarId = 2, ColorId = 2, BrandId =2, ModelYear =2021, DailyPrice = 200, Description = "Benzinli araç"},
                new Car{CarId = 3, ColorId = 3, BrandId =3, ModelYear =2021, DailyPrice = 300, Description = "Elektrikli araç"},
                new Car{CarId = 4, ColorId = 1, BrandId =1, ModelYear =2020, DailyPrice = 400, Description = "Hibrit araç"}
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.CarId == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            // Gönderdiğimiz ürünün ID2sine sahip ürünü bul.
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

        public void Delete(Car car)
        {
            //Eğer Linq kullanmasaydık buradaki kodlarla bir döngü yaratıp bizim gönderdiğimiz car ID'sini listemizde(ya da vertabanımızda) bulunan car ID'si ile karşılaştırcaktık. Eşleşmeyi bulduktan sonra da car nesnesini "_cars.Remove(carToDelete);" fonksiyonu ile silecektik.

            //Car carToDelete=null;
            //foreach (var p in _cars )
            //{
            //    if (car.Id == p.Id)
            //    {
            //        carToDelete = p;
            //    }
            //}


            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(carToDelete);

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
