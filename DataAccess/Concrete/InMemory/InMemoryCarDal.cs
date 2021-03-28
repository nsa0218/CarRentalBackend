using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:IEntityRepository<Car>
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=2,ColorId= 3, CarName="Passat", DailyPrice=500, ModelYear=2020, Description="1.6 Dizel"},
                new Car {Id=2, BrandId=3,ColorId= 2, CarName="clio", DailyPrice=300, ModelYear=2020, Description="1.0 Benzin"},
                new Car {Id=3, BrandId=3,ColorId= 1, CarName="320i", DailyPrice=400, ModelYear=2020, Description="1.6 Dizel"},
                new Car {Id=3, BrandId=1,ColorId= 3, CarName="Polo", DailyPrice=200, ModelYear=2020, Description="1.4 TSI"},
                new Car {Id=4, BrandId=1,ColorId= 2, CarName="Captur", DailyPrice=250, ModelYear=2020, Description="1.4 Benzin"}

            };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public void Update(Car entity)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == entity.Id);
            carToUpdate.CarName = entity.CarName;
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
        }
    }
}
