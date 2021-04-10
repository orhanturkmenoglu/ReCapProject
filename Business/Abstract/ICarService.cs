using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        List<Car> GetModelYears(int model);
        List<Car> GetDailPrice(int dailPrice);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
