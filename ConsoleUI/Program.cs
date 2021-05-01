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

            //var result = carManager.GetAll();
            //if (result.Success)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.Descriptions);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            Customer customer1 = new Customer() { UserId = 1, CompanyName = "Kampanya 1" };

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());


            //var result = customerManager.Add(customer1);
            //if (result.Success)
            //{
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine("İşlem başarısız");
            //}

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

            Rental rental = new Rental() { CarId = 1, CustomerId = 11, RentDate = DateTime.Now };


            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //var result = rentalManager.Add(rental);
            //if (result.Success)
            //{
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            var result = rentalManager.GetRentalDetailDto();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine("FirstName : {0} LastName: {1} CarName: {2} CompanyName: {3} BrandName: {4} ModelYear: {5} DailyPrice: {6} RentDate: {7} " +
                        "ReturnDate: {8}", item.FirstName, item.LastName, item.CarName, item.CompanyName, item.BrandName, item.ModelYear, item.DailyPrice, item.RentDate, item.ReturnDate);
                }
            }

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
