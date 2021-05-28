using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bisuness.Abstract
{
    public interface ICountryService
    {
        IDataResult<List<Country>> GetList();
        IDataResult<Country> GetById(int id);
        IResult Add(Country country);
        IResult Update(Country country);
        IResult Delete(Country country);
    }

}
