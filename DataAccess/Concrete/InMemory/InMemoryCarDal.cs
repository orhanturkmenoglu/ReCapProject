using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{CarID=1,BrandID=1,ColorID=1,ModelYear="1998",DailyPrice=80,Descriptions="Opel Corsa"},
                new Car{CarID=2,BrandID=2,ColorID=2,ModelYear="2018",DailyPrice=120,Descriptions="Symbol 1.6"},
                new Car{CarID=3, BrandID=3,ColorID=3,ModelYear="2013",DailyPrice=100,Descriptions="Ford Focus"},
                new Car{CarID=4,BrandID=4,ColorID=3,ModelYear="2015",DailyPrice=110,Descriptions="Polo"},
                new Car{CarID=5,BrandID=4,ColorID=1,ModelYear="2020",DailyPrice=250,Descriptions="Wolksagen Passat"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarID == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetDailPrice(int dailPrice)
        {
            var result = _cars.Any(c => c.DailyPrice == dailPrice);

            if (result)
            {
                return _cars;
            }

            return _cars;


        }

        public List<Car> GetModelYears(string model)
        {

            return _cars.Where(c => c.ModelYear==model).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarID == car.CarID);

            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;

        }
    }
}
