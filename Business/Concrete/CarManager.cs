using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public List<Car> GetAll()
        {
            //İş kodları

            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Add(Car car)
        {
            if (car.Description.Length <= 2 || car.DailyPrice <= 0)
            {
                Console.WriteLine("Araç tanımı 2 karakter veya daha uzun olmalıdır; araç günlük fiyatı 0'dan büyük olmalıdır");
            }
            else
            {
                _carDal.Add(car);
            }
            
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
