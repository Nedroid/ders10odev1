using Core.Utilities.Results;
using RecapProjectCar.Entities;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IResult Update(Color color);
        IResult Delete(Color color);
        IResult Add(Color color);
    }
}

