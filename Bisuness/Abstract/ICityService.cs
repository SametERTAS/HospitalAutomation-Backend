using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bisuness.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetList();
        IDataResult<City> GetByPlateCode(int plateCode);
        IResult Add(City city);
        IResult Update(City city);
        IResult Delete(City city);
    }

}
