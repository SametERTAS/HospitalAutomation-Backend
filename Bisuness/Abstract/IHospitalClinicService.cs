using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IHospitalClinicService
    {
        IDataResult<List<HospitalClinic>> GetList();
        IDataResult<HospitalClinic> GetById(int id);
        IResult Add(HospitalClinic hospitalClinic);
        IResult Update(HospitalClinic hospitalClinic);
        IResult Delete(HospitalClinic hospitalClinic);
    }

}
