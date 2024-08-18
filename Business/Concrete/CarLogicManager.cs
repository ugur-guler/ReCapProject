using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarLogicManager : ICarLogicService
    {
        ICarDao _carDao;
        public CarLogicManager(ICarDao carDao)
        {
            _carDao = carDao;
        }
        public void Add(Car car)
        {
            // there isn't any logical rules.
            _carDao.Add(car);
        }

        public void Delete(Car car)
        {
            _carDao.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDao.GetAll();
        }

        public Car GetById(int Id)
        {
            return _carDao.GetById(Id);
        }

        public void Update(Car car)
        {
            _carDao.Update(car);
        }
    }
}
