using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICountryService
    {
        IDataResult<List<Country>> GetList();
        IDataResult<Country> GetByPhoneCode(int phoneCode);
        IResult Add(Country country);
        IResult Update(Country country);
        IResult Delete(Country country);
    }

}
