using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentAcarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentAcarContext context = new RentAcarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandID equals b.BrandID
                             join o in context.Colors
                             on c.ColorID equals o.ColorID
                             select new CarDetailDto
                             {
                                 CarName = c.Descriptions,
                                 BrandName = b.BrandName,
                                 ColorName = o.ColorName,
                                 DailyPrice = c.DailyPrice

                             };

                return result.ToList();
                          
            }
        }
    }
}
