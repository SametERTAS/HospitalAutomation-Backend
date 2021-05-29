using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IClinicService
    {
        IDataResult<List<Clinic>> GetList();
        IDataResult<Clinic> GetByName(string name);
        IResult Add(Clinic clinic);
        IResult Update(Clinic clinic);
        IResult Delete(Clinic clinic);
    }

}
