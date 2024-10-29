using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System;
using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

namespace ConsoleUPPPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICarDal inMemoryCarDal = new InMemoryCarDal();
            Car ozanc = new Car {Id = 5,ModelYear = 2023 };
            inMemoryCarDal.Add(ozanc);

                
            foreach(Car car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }
            Console.WriteLine("----------------");

            inMemoryCarDal.Update(new Car {Id = 5, ModelYear=1980  });




            foreach(Car car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}
