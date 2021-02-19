using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi!";
        public static string CarNameInvalid = "Araç adı istenen kurallara uygun girilmedi!";
        public static string CarsListed = "Araçlar listelendi!";
        public static string MaintenanceTime = "Bakım zamanı olduğu için araçlar listelenemez!";
        public static string CarsListedByBrandId = "Araçlar seçilen markaya göre listelendi!";
        public static string CarsListedColordId = "Araçlar seçilen renge göre listelendi!";
        public static string CarListed = "Araç listelendi!";
        public static string CarDeleted = "Araç silindi!";
        public static string CarUpdated = "Araç güncellendi!";
        public static string ColorsListed = "Renkler listelendi!";
        public static string ColorListedById = "Renkler id'ye göre listelendi!";
        public static string ColorNameInvalid = "Renk adı 2 karakterden fazla olmalıdır!";
        public static string ColorAdded = "Renk eklendi!";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string BrandsListed = "Markalar litelendi!";
        public static string BrandListedById = "Markalar id'ye göre listelendi";
        public static string BrandNameInvalid = "Marka adı 2 karakterden fazla olmalıdır!";
        public static string BrandAdded = "Marka eklendi!";
        public static string BrandUpdated = "Marka güncellendi!";
        public static string BrandDeleted = "Marka silindi";
        public static string CustomersListed = "Müşteriler listelendi!";
        public static string CustomersListedById = "Müşteriler id'ye göre listelendi";
        public static string CustomerListedByUserId = "Müşteriler kullanıcı id'sine göre listelendi!";
        public static string CarDetailsListed = "Araçlar detayları ile blirkte listelendi!";
        public static string CustomerListed = "Müşteri listelendi!";
        public static string CustomerAdded = "Müşteri eklendi!";
        public static string CustomerUpdated = "Müşteri güncellendi!";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string UsersListed = "Kullanıcılar listelendi!";
        public static string UsersListedById = "Kulanıcılar id'ye göre listelendi!";
        public static string UserListedById = "Kullanıcı id'ye göre listelendi!";
        public static string UserAdded = "Kullanıcı eklandi!";
        public static string UserUpdated = "KUllanıcı düncellendi!";
        public static string UserDeleted = "Kullanıcı silindi!";
        public static string BrandListed = "Marka listelendi!";
        internal static string RentalsListed;
        internal static string RentalsListedByCustomerId;
        internal static string RentalsListedByCarId;
        internal static string RentalListedById;
        internal static List<Rental> RentalDateInvalid;
        internal static List<Rental> ReturnDateInvalid;
        internal static string RentalAdded;
        internal static string RentalUpdated;
        internal static string RentalDeleted;
    }
}
