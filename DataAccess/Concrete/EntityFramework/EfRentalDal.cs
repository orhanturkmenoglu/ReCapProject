using Core.DataAccess.EntityFramework;
using Core.Utilities.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentAcarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentAcarContext context = new RentAcarContext())
            {
                var result = from rental in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars
                             on rental.CarId equals car.CarID
                             join customer in context.Customers
                             on rental.CustomerId equals customer.CustomerId
                             join brand in context.Brands
                             on car.BrandID equals brand.BrandID
                             join color in context.Colors
                             on car.ColorID equals color.ColorID
                             join user in context.Users
                             on customer.UserId equals user.UserId
                             select new RentalDetailDto
                             {
                                 CarName = car.Descriptions,
                                 FirstName=user.FirstName,
                                 LastName=user.LastName,
                                 BrandName=brand.BrandName,
                                 DailyPrice=car.DailyPrice,
                                 ModelYear=car.ModelYear,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                                 CompanyName = customer.CompanyName
                             };

                return result.ToList();
            }
        }
    }
}
