using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CarDao:ICarDao
    {
        public List<Car> cars;
        public CarDao() {
            cars.Add(new Car(1, 1, 1, 122321, "Part of M5 series"));
            cars.Add(new Car(2, 2, 2, 122321, "Part of M6 series"));
            cars.Add(new Car(3, 2, 3, 122321, "Part of M7 series"));
            cars.Add(new Car(4, 3, 3, 122321, "Part of M3 series"));
            cars.Add(new Car(5, 1, 2, 122321, "Part of M9 series"));

        }


        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar = cars.SingleOrDefault(p=>p._Id==car._Id);
            if(deletedCar!= null)
            {
                cars.Remove(deletedCar);
            }
            
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public Car GetById(int Id)
        {
            Car car = cars.SingleOrDefault(p => p._Id == Id);
            if (car != null)
            {
                cars.Remove(car);
                return car;
            }
            else
            {
                throw new ArgumentException($"ID'si {Id} olan bir araç bulunamadı.");
            }

        }

        public void Update(Car car)
        {
            Car uptadedCar = cars.SingleOrDefault(p=> p._Id==car._Id);
            if (uptadedCar != null)
            {
                cars[uptadedCar._Id - 1]._BrandID = car._BrandID;
                cars[uptadedCar._Id - 1]._ColorId = car._ColorId;
                cars[uptadedCar._Id - 1]._DailyPrice = car._DailyPrice;
                cars[uptadedCar._Id - 1]._Description = car._Description;
            }
            else
            {
                throw new ArgumentException("İt is not find ");
            }
        }
    }
}
