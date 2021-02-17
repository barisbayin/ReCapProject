using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    interface IBrandSevice
    {
        List<Brand> GetAll();
        List<Brand> GetBrandsByBrandId(int id);

        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
