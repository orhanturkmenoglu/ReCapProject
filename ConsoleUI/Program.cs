using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Descriptions);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }



            // GetAll(carManager);
            // GetById(carManager);
            // Add(carManager);
            // Delete(carManager);
            // Update(carManager);
            // ModelYears(carManager);
            // DailPrice(carManager);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Descriptions);
            //}

            // CarAddTest(carManager);

           // CarDetailsTest(carManager);

            Console.ReadLine();
        }

        private static void CarDetailsTest(CarManager carManager)
        {
            foreach (var item in carManager.GetCarDetails().Data)
            {

                Console.WriteLine("CarName {0} : BrandName {1} : ColorName {2} : DailyPrice {3} :", item.CarName, item.BrandName, item.ColorName, item.DailyPrice);

            }
        }

        private static void CarAddTest(CarManager carManager)
        {
            Car car1 = new Car()
            {
                CarID = 18,
                BrandID = 1,
                ColorID = 1,
                DailyPrice = -10,
                Descriptions = "Pe",
                ModelYear = "1999"
            };

            carManager.Add(car1);
        }

        private static void DailPrice(CarManager carManager)
        {
            foreach (var item in carManager.GetDailPrice(250).Data)
            {
                Console.WriteLine(item.Descriptions);
            }
        }

        private static void ModelYears(CarManager carManager)
        {
            foreach (var item in carManager.GetModelYears("1998").Data)
            {
                Console.WriteLine(item.Descriptions);
            }
        }

        private static void Update(CarManager carManager)
        {
            Car car6 = new Car()
            {
                CarID = 6,
                BrandID = 4,
                ColorID = 1,
                DailyPrice = 50,
                ModelYear = "2000",
                Descriptions = "Doğan görünümlü şahin"
            };

            carManager.Update(car6);


        }

        private static void Delete(CarManager carManager)
        {
            Car car6 = new Car()
            {
                CarID = 6,
                BrandID = 4,
                ColorID = 1,
                DailyPrice = 50,
                ModelYear = "2000",
                Descriptions = "Doğan görünümlü şahin"
            };

            carManager.Delete(car6);
        }

        private static void GetAll(CarManager carManager)
        {
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Descriptions);
            }
        }

        private static void GetById(CarManager carManager)
        {
            //foreach (var item in carManager.GetById(1))
            //{
            //    Console.WriteLine(item.Descriptions);
            //}
        }

        private static void Add(CarManager carManager)
        {
            Car car6 = new Car()
            {
                CarID = 6,
                BrandID = 4,
                ColorID = 1,
                DailyPrice = 50,
                ModelYear = "2000",
                Descriptions = "Doğan görünümlü şahin"
            };

            carManager.Add(car6);

        }
    }
}
