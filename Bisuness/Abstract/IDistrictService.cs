using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bisuness.Abstract
{
    public interface IDistrictService
    {
        IDataResult<List<District>> GetList();
        IDataResult<District> GetById(int id);
        IResult Add(District district);
        IResult Update(District district);
        IResult Delete(District district);
    }

}
