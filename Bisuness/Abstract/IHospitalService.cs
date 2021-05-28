using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bisuness.Abstract
{
    public interface IHospitalService
    {
        IDataResult<List<Hospital>> GetList();
        IDataResult<Hospital> GetById(int id);
        IResult Add(Hospital hospital);
        IResult Update(Hospital hospital);
        IResult Delete(Hospital hospital);
    }

}
