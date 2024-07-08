using ConsoleApp1.Business.Abstract;
using ConsoleApp1.Business.Constants;
using ConsoleApp1.DataAccess.Abstract;
using Core.Utilities.Results;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _ıcolorDal;

        public ColorManager(IColorDal ıColorDal)
        {
            _ıcolorDal = ıColorDal;
        }

        public IResult Add(Color color)
        {
           _ıcolorDal.Add(color);
            return new Result(true,Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _ıcolorDal.Delete(color);
            return new Result(true, Messages.ColorDeleted);
            
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_ıcolorDal.GetAll(), Messages.ColorListed);
        }

        public IResult Update(Color color)
        {
           _ıcolorDal.Update(color);
            return new Result(true, Messages.ColorUpdated);
        }
    }
}
