using System;
using System.Collections.Generic;
using System.Text;
using Core;


namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ?  ReturnDate { get; set; }
    }
}
