using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IDataResult<List<District>> GetList();
        IDataResult<District> GetByPhoneCode(int phoneCode);
        IResult Add(District district);
        IResult Update(District district);
        IResult Delete(District district);
    }

}
