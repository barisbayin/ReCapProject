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




            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("------------------------------Veri tabanındaki tüm renkler------------------------------");

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("Renk ID: {0}, Renk Adı: {1}",color.Id,color.ColorName);
            }

            Console.WriteLine("------------------------------Veri tabanında Id = 1 olan renk------------------------------");

            foreach (var color in colorManager.GetColorsByColorId(1))
            {
                Console.WriteLine("Id=1 olan renk: {0}",color.ColorName);
            }

            //Console.WriteLine("------------------------------Veri tabanına 'Gri' rengini ekleyelim------------------------------");

            //colorManager.Add(new Color{ColorName = "Gri"});


            //Console.WriteLine("------------------------------Veri tabanındaki tüm renkler------------------------------");

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(" Renk ID: {0}, Renk Adı: {1}", color.Id, color.ColorName);
            //}




            Console.WriteLine("------------------------------Veri tabanındaki Id=10 olan rengi değiştirelim ------------------------------");

            




            Console.WriteLine("------------------------------Veri tabanındaki tüm renkler------------------------------");

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(" Renk ID: {0}, Renk Adı: {1}", color.Id, color.ColorName);
            }





            BrandManager brandManager =new BrandManager(new EfBrandDal());

            Console.WriteLine("------------------------------Veri tabanındaki tüm markalar------------------------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Marka ID: {0}, Marka Adı: {1}",brand.Id,brand.BrandName);
            }

            Console.WriteLine("------------------------------Veri tabanındaki Id 1 ve 2 olan markalar------------------------------");

            foreach (var brand in brandManager.GetAll())
            {
                if (brand.Id == 1 || brand.Id == 2)
                {
                    Console.WriteLine("Id={0} olan marka: {1} ",brand.Id,brand.BrandName);
                }
            }


            //Console.WriteLine("------------------------------Veri tabanına 'Volvo' markasını ekleyelim------------------------------");

            //brandManager.Add(new Brand{BrandName = "Volvo"});


            Console.WriteLine("------------------------------Veri tabanındaki tüm markalar------------------------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Marka ID: {0}, Marka Adı: {1}", brand.Id, brand.BrandName);
            }


            Console.WriteLine("------------------------------Veri tabanındaki tüm markalar------------------------------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Marka: {0} | Renk: {1}  | Model Yılı: {2} | Günlük Fiyat: {3}  | Tanımlama: {4}", car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Description);
            }

        }
    }
}
