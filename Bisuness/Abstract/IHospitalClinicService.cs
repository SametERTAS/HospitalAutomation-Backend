using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bisuness.Abstract
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
