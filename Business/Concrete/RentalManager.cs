using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {

            ValidationTool.Validate(new RentalValidator(),rental);

            //var result = _rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null);

            //if (!result.Any())
            //{
            //    _rentalDal.Add(rental);
            //    return new SuccessResult(Messages.RentalAdded);

            //}


            return new ErrorResult(Messages.ReturnDateIsEmpty);

        }

       

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDto()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }
    }
}
