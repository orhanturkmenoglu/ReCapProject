using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (!(car.Descriptions.Length>=2))
            {
                Console.WriteLine("Araba ismi minimum iki karakter olmalıdır!!");
            }

            if (!(car.DailyPrice>0))
            {
                Console.WriteLine("Araba günlük fiyat 0 dan büyük  olmalıdır!!");
            }

            _carDal.Add(car);

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public void GetById(int id)
        {
             _carDal.Get(c => c.CarID == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandID == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorID == colorId);
        }

        public List<Car> GetDailPrice(int dailPrice)
        {

            return _carDal.GetAll(c => c.DailyPrice == dailPrice);
        }

        public List<Car> GetModelYears(string model)
        {
            return _carDal.GetAll(c => c.ModelYear == model);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
