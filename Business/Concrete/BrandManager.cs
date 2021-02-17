using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandSevice
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetBrandsByBrandId(int id)
        {
            return _brandDal.GetAll(p => p.Id == id);
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length <= 2)
            {
                Console.WriteLine("Marka adı 2 karakter veya daha uzun olmalıdır");
            }
            else
            {
                _brandDal.Add(brand);
            }
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
    }
}
