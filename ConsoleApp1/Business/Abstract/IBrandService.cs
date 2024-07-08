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
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IResult Add(Brand brand);
    }
}
