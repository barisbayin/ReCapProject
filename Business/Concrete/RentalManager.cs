using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<List<Rental>> GetRentalsByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.CustomerId == id), Messages.RentalsListedByCustomerId);
        }

        public IDataResult<List<Rental>> GetRentalsByCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(P => P.CarId == id), Messages.RentalsListedByCarId);
        }

        public IDataResult<Rental> GetRentalById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentalId == id), Messages.RentalListedById);
        }

        public IDataResult<List<Rental>> GetByRentalDate(DateTime date1, DateTime date2)
        {
            if (date1 < date2)
            {
                return new ErrorDataResult<List<Rental>>(Messages.RentalDateInvalid);
            }
            else
            {
                return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.RentDate >= date1 && p.RentDate <= date2));
            }
        }

        public IDataResult<List<Rental>> GetByReturnDate(DateTime date1, DateTime date2)
        {
            if (date1 < date2)
            {
                return new ErrorDataResult<List<Rental>>(Messages.ReturnDateInvalid);
            }
            else
            {
                return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.ReturnDate >= date1 && p.ReturnDate <= date2));
            }

        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(),Messages.RentalDetailsListed);
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var rentalListByCarId = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            if (rentalListByCarId.Count>0)
            {
                foreach (var rentalByCarId in rentalListByCarId)
                {
                    if (rentalByCarId.ReturnDate==null)
                    {
                        return new ErrorResult(Messages.CarAlreadyRented);
                    }
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            var rentalListByCarId = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            if (rentalListByCarId.Count > 0)
            {
                foreach (var rentalByCarId in rentalListByCarId)
                {
                    if (rentalByCarId.ReturnDate == null)
                    {
                        _rentalDal.Update(rental);
                        
                    }
                }
            }
            return new SuccessResult(Messages.RentalUpdated);
        }


        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }
    }
}
