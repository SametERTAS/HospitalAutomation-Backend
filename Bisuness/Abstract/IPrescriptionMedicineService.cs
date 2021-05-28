using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bisuness.Abstract
{
    public interface IPrescriptionMedicineService
    {
        IDataResult<List<PrescriptionMedicine>> GetList();
        IDataResult<PrescriptionMedicine> GetById(int id);
        IResult Add(PrescriptionMedicine prescriptionMedicine);
        IResult Update(PrescriptionMedicine prescriptionMedicine);
        IResult Delete(PrescriptionMedicine prescriptionMedicine);
    }

}
