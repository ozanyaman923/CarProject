using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id = 1 , BrandId = 1 , ColorId = 5, DailyPrice =500, Description = "Hızlı" , ModelYear = 2015},
                new Car {Id = 2 , BrandId = 2 , ColorId = 5, DailyPrice =700, Description = "Konfor" , ModelYear = 2016},
                new Car {Id = 3 , BrandId = 3 , ColorId = 5, DailyPrice =400, Description = "Tatil" , ModelYear = 2012},
                new Car {Id = 4 , BrandId = 4 , ColorId = 5, DailyPrice =900, Description = "Karavan1" , ModelYear = 2014}};
        }
        public void Add(Car car)
        {
            _cars.Add(car); 
        }

        public void Delete(Car car)     //BRAVO 
        {
            Car aranancar = _cars.SingleOrDefault(p=>p.Id==car.Id );
            _cars.Remove(aranancar);
        }
        public void Update(Car car)
        {
            Car aranancar = _cars.SingleOrDefault(p => p.Id == car.Id);
            aranancar.DailyPrice = car.DailyPrice;
            aranancar.ModelYear = car.ModelYear;
            aranancar.BrandId = car.BrandId;
            aranancar.ColorId = car.ColorId;
            aranancar.Description = car.Description;
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
    }
}
