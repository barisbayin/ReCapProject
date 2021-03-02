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
        public static string UserAdded = "Kullanıcı eklendi!";
        public static string UserUpdated = "KUllanıcı düncellendi!";
        public static string UserDeleted = "Kullanıcı silindi!";
        public static string BrandListed = "Marka listelendi!";
        public static string RentalsListed="Araç kiralama listesi yüklendi!";
        public static string RentalsListedByCustomerId="Araç kiralama listesi müşteri id'sine göre listelendi!";
        public static string RentalsListedByCarId="Araç kiralama listesi araç id'sine göre listelendi!";
        public static string RentalListedById="Kiralık araç id'ye göre listelendi";
        public static string RentalDateInvalid="Geçersiz tarih seçimi: ilk tarih son tarihten büyük olamaz!";
        public static string ReturnDateInvalid= "Geçersiz tarih seçimi: ilk tarih son tarihten büyük olamaz!";
        public static string RentalAdded="Araç kiralama işlemi kaydedildi!";
        public static string RentalUpdated="Araç kiralama işlemi güncellendi!";
        public static string RentalDeleted="Araç kiralama işlemi silindi!";
        public static string RentalDetailsListed="Kiralama detayları listelendi!";
        public static string CarAlreadyRented="Araç zaten kiralanmış!";
        public static string CarImagesListed="Araç fotoğrafları listelendi";
        public static string CarImagesListedByCarId="Araç fotoğrafları Id'ye göre listelendi!";
        public static string CarImageAdded="Araç fotoğrafı eklendi!";
        public static string CarImageDeleted="Araç fotoğrafı silinidi!";
        public static string CarImageUpdated="Araç fotoğrafı güncellendi!";
        public static string CarImageLimitExceeded="Araç fotoğraf sayısı maksimum limitin üzerinde!";
    }
}
