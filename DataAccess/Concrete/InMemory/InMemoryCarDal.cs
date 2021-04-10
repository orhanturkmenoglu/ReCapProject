using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars = new List<Car>();
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=1998,DailyPrice=80,Description="Opel Corsa"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2018,DailyPrice=120,Description="Symbol 1.6"},
                new Car{Id=3,BrandId=3,ColorId=3,ModelYear=2013,DailyPrice=100,Description="Ford Focus"},
                new Car{Id=4,BrandId=4,ColorId=3,ModelYear=2015,DailyPrice=110,Description="Polo"},
                new Car{Id=5,BrandId=4,ColorId=1,ModelYear=2020,DailyPrice=250,Description="Wolksagen Passat"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }

        public List<Car> GetDailPrice(int dailPrice)
        {
            var result = _cars.Any(c=>c.DailyPrice==dailPrice);

            if (result)
            {
                return _cars;
            }

            return _cars;
        

        }

        public List<Car> GetModelYears(int model)
        {

          return  _cars.Where(c => c.ModelYear<=model).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
