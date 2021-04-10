using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            // GetAll(carManager);
            // GetById(carManager);
            // Add(carManager);
            // Delete(carManager);
            // Update(carManager);

            Console.ReadLine();
        }

        private static void Update(CarManager carManager)
        {
            Car car6 = new Car()
            {
                Id = 6,
                BrandId = 4,
                ColorId = 1,
                DailyPrice = 50,
                ModelYear = 2000,
                Description = "Doğan görünümlü şahin"
            };
            carManager.Update(car6);
        }

        private static void Delete(CarManager carManager)
        {
            Car car6 = new Car()
            {
                Id = 6,
                BrandId = 4,
                ColorId = 1,
                DailyPrice = 50,
                ModelYear = 2000,
                Description = "Doğan görünümlü şahin"
            };

            carManager.Delete(car6);
        }

        private static void GetAll(CarManager carManager)
        {
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }

        private static void GetById(CarManager carManager)
        {
            foreach (var item in carManager.GetById(1))
            {
                Console.WriteLine(item.Description);
            }
        }

        private static void Add(CarManager carManager)
        {
            Car car6 = new Car()
            {
                Id = 6,
                BrandId = 4,
                ColorId = 1,
                DailyPrice = 50,
                ModelYear = 2000,
                Description = "Doğan görünümlü şahin"
            };

            carManager.Add(car6);

        }
    }
}
