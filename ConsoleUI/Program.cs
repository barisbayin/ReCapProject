using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Console.WriteLine(rentalManager.Add(new Rental{CarId = 2,CustomerId = 2,RentDate = DateTime.Now}).Message);

            Console.WriteLine("-----------------------------Kiralama listesi-----------------------------");

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("Kiralama Id: {0}, Araç Id: {1} Müşterin Id: {2}, Kiralama Tarihi: {3}, Araç Teslim Tarihi: {4}", rental.RentalId, rental.CarId, rental.CustomerId, rental.RentDate,rental.ReturnDate);
            }


            
            Console.WriteLine("-----------------------------Kiralama Detay listesi-----------------------------");


            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine("Kiralama Id: {0}, Araç Id: {1} Marka: {2}, Model Yılı: {3}, Araç Rengi:{4}, Günlük Fiyat: {5}, Araç Tanımı: {6} ,Müşteri Id: {7}, Müşteri Adı: {8}, Müşteri Soydı:{9}, Şirket Adı: {10},Müşteri Email: {11}, Kiralama Tarihi Id: {12}, Teslim Tarihi {13}" , rental.RentalId, rental.CarId, rental.BrandName, rental.Color, rental.ModelYear, rental.DailyPrice,rental.Description, rental.CustomerId, rental.CustomerFirstName,rental.CustomerLastName,rental.CompanyName, rental.Email, rental.RentDate, rental.ReturnDate);
            }

            Console.WriteLine(rentalManager.Update(new Rental {RentalId = 1, CarId = 2, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(1) }).Message);

            Console.WriteLine("-----------------------------Kiralama listesi-----------------------------");

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("Kiralama Id: {0}, Araç Id: {1} Müşterin Id: {2}, Kiralama Tarihi: {3}, Araç Teslim Tarihi: {4}", rental.RentalId, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
            }

            //CustomerManager customerManager=new CustomerManager(new EfCustomerDal());

            //Console.WriteLine(customerManager.Add(new Customer { UserId =5, CompanyName = "DSV Lojistik"}).Message);

            //Console.WriteLine("-----------------------------Kullanıcı listesi-----------------------------");

            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine("Müşteri Id: {0}, Müşterin KUllanıcı Id: {1}, Şirket Adı:{2} ", customer.CustomerId, customer.UserId, customer.CompanyName);
            //}

            //Console.WriteLine("-----------------------------Kullanıcı detay listesi-----------------------------");

            //foreach (var customer in customerManager.GetCustomerDetails().Data)
            //{
            //    Console.WriteLine("Müşteri Id: {0}, Müşteri Kullanıcı Id No: {1}, Müşteri Adı {2}, Müşteri Soyadı: {3}, Şirket Adı: {4}, Email:{5}, Şifre{6}", customer.CustomerId, customer.UserId, customer.FirstName, customer.LastName, customer.CompanyName,customer.Email,customer.Password);
            //}

            //UserManager userManager=new UserManager(new EfUserDal());

            //Console.WriteLine(userManager.Add(new User { FirstName = "Ezgi", LastName = "Yücel", Email = "ezgiyucel@xmail.com", Password = "12345" }).Message);

            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine("-----------------------------Kullanıcı listesi-----------------------------");
            //    Console.WriteLine("Kullanıcı Id: {0}, KUllanıcı Adı: {1}, Kullanıcı Soyadı:{2}, Email{3}, Şifre{4}",user.UserId,user.FirstName,user.LastName,user.Email,user.Password);
            //}



            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetails();

            //if (result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine("Marka: {0} | Renk: {1}  | Model Yılı: {2} | Günlük Fiyat: {3}  | Tanımlama: {4}", car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Description);
            //    }
            //}


            //Console.WriteLine("------------------------------Tüm Araçlar------------------------------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Marka: {0} Renk: {1} Model Yılı: {2} Günlük Fiyat: {3} Tanımlama: {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            //}

            //Console.WriteLine("------------------------------Rengi 1 Olan Araçlar------------------------------");
            //foreach (var car in carManager.GetAllCarsByColorId(1))
            //{
            //    Console.WriteLine("Marka: {0} Renk: {1} Model Yılı: {2} Günlük Fiyat: {3} Tanımlama: {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            //}

            //Console.WriteLine("------------------------------Markası 4 Olan Araçlar------------------------------");
            //foreach (var car in carManager.GetAllCarsByBrandId(4))
            //{
            //    Console.WriteLine("Marka: {0} Renk: {1} Model Yılı: {2} Günlük Fiyat: {3} Tanımlama: {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            //}

            //Console.WriteLine("------------------------------Hatalı araç ekleme------------------------------");

            //CarManager carManager2 = new CarManager(new EfCarDal());

            //carManager2.Add(new Car{BrandId = 2, ColorId = 1,DailyPrice = 500, Description = "A"});




            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //Console.WriteLine("------------------------------Veri tabanındaki tüm renkler------------------------------");

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine("Renk ID: {0}, Renk Adı: {1}",color.Id,color.ColorName);
            //}

            //Console.WriteLine("------------------------------Veri tabanında Id = 1 olan renk------------------------------");

            //foreach (var color in colorManager.GetColorsByColorId(1))
            //{
            //    Console.WriteLine("Id=1 olan renk: {0}",color.ColorName);
            //}

            ////Console.WriteLine("------------------------------Veri tabanına 'Gri' rengini ekleyelim------------------------------");

            ////colorManager.Add(new Color{ColorName = "Gri"});


            ////Console.WriteLine("------------------------------Veri tabanındaki tüm renkler------------------------------");

            ////foreach (var color in colorManager.GetAll())
            ////{
            ////    Console.WriteLine(" Renk ID: {0}, Renk Adı: {1}", color.Id, color.ColorName);
            ////}




            //Console.WriteLine("------------------------------Veri tabanındaki Id=10 olan rengi değiştirelim ------------------------------");






            //Console.WriteLine("------------------------------Veri tabanındaki tüm renkler------------------------------");

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(" Renk ID: {0}, Renk Adı: {1}", color.Id, color.ColorName);
            //}





            //BrandManager brandManager =new BrandManager(new EfBrandDal());

            //Console.WriteLine("------------------------------Veri tabanındaki tüm markalar------------------------------");
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine("Marka ID: {0}, Marka Adı: {1}",brand.Id,brand.BrandName);
            //}

            //Console.WriteLine("------------------------------Veri tabanındaki Id 1 ve 2 olan markalar------------------------------");

            //foreach (var brand in brandManager.GetAll())
            //{
            //    if (brand.Id == 1 || brand.Id == 2)
            //    {
            //        Console.WriteLine("Id={0} olan marka: {1} ",brand.Id,brand.BrandName);
            //    }
            //}


            ////Console.WriteLine("------------------------------Veri tabanına 'Volvo' markasını ekleyelim------------------------------");

            ////brandManager.Add(new Brand{BrandName = "Volvo"});


            //Console.WriteLine("------------------------------Veri tabanındaki tüm markalar------------------------------");
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine("Marka ID: {0}, Marka Adı: {1}", brand.Id, brand.BrandName);
            //}


            //Console.WriteLine("------------------------------Veri tabanındaki tüm markalar------------------------------");
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("Marka: {0} | Renk: {1}  | Model Yılı: {2} | Günlük Fiyat: {3}  | Tanımlama: {4}", car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Description);
            //}

        }
    }
}
