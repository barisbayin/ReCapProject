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
    }
}
