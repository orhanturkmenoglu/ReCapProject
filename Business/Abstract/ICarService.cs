using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        void GetById(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetModelYears(string model);
        List<Car> GetDailPrice(int dailPrice);

        List<CarDetailDto> GetCarDetails();

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
