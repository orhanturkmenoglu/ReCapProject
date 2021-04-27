using Core.Utilities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetModelYears(string model);
        IDataResult<List<Car>> GetDailPrice(int dailPrice);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
