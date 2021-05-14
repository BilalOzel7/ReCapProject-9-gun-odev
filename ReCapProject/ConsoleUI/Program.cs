using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using Entities;
using System;

namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Delete(new Car { CarId = 9 });
            //carManager.Add(new Car { CarName = "Tesla", BrandId = 1, DailyPrice = 50, ColorId = 2, ModelYear = 2020, Description="Sıfır" });
            //carManager.Update(new Car { CarId = 8, CarName = "Opel", ColorId = 2 });

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarName);
            }

            
            
            
        }
    }
}
 