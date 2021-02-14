using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager  carManager=new CarManager(new EfCarDal());

            Console.WriteLine("------------------------------Tüm Araçlar------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka: {0} Renk: {1} Model Yılı: {2} Günlük Fiyat: {3} Tanımlama: {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("------------------------------Rengi 1 Olan Araçlar------------------------------");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine("Marka: {0} Renk: {1} Model Yılı: {2} Günlük Fiyat: {3} Tanımlama: {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("------------------------------Markası 4 Olan Araçlar------------------------------");
            foreach (var car in carManager.GetCarsByBrandId(4))
            {
                Console.WriteLine("Marka: {0} Renk: {1} Model Yılı: {2} Günlük Fiyat: {3} Tanımlama: {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("------------------------------Hatalı araç ekleme------------------------------");

            CarManager carManager2 = new CarManager(new EfCarDal());

            carManager2.Add(new Car{BrandId = 2, ColorId = 1,DailyPrice = 500, Description = "A"});
        }
    }
}
