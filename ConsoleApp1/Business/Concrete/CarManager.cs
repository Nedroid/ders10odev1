using ConsoleApp1.Business.Constants;
using ConsoleApp1.DataAccess.Concrete;
using Core.Utilities.Results;
using RecapProjectCar.Business.Abstract;
using RecapProjectCar.DataAccess.Abstract;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProjectCar.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        public CarManager(ICarDal icardal)
        {
            _icarDal = icardal;
        }
        public IResult Add(Car car)
        {
            if(car.ModelYear<1990)
            {
                return new ErrorResult(Messages.CarInvalidModel);
            }

            _icarDal.Add(car);
            Console.WriteLine(" Added Car | Id :  " + car.Id);
            return new Result(true,Messages.CarAdded);
        }

        public IResult Delete(Car car)
        { 
            _icarDal.Delete(car);
            Console.WriteLine("deleted car ="+ car.Id);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_icarDal.Get(c=>c.Id==id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _icarDal.GetCarDetailDto(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll(c => c.BrandId == brandId));  
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll(c => c.ColorId == colorId));
        }

  

        public IDataResult<Car> Update(Car car)
        {
            car = _icarDal.Update(car);
            Console.WriteLine("updated car " + car.Id);

            return new SuccessDataResult<Car>(car);
        }
    }
}
