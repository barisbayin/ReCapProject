using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalsByCustomerId(int id);
        IDataResult<List<Rental>> GetRentalsByCarId(int id);
        IDataResult<Rental> GetRentalById(int id);
        IDataResult<List<Rental>> GetByRentalDate(DateTime date1, DateTime date2);
        IDataResult<List<Rental>> GetByReturnDate(DateTime date1, DateTime date2);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult CarAvailabilityCheck(Rental rental);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);


    }
}
