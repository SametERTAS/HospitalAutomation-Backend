using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result.Concrete;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PrescriptionMedicineManager :IPrescriptionMedicineService
    {
        private IPrescriptionMedicineDal _prescriptionMedicineDal;

        public PrescriptionMedicineManager(IPrescriptionMedicineDal prescriptionMedicineDal)
        {
            _prescriptionMedicineDal = prescriptionMedicineDal;
        }

        public IResult Add(PrescriptionMedicine prescriptionMedicine)
        {
            _prescriptionMedicineDal.Add(prescriptionMedicine);
            return new SuccessResult(Messages.PrescriptionMedicineCreated);
        }

        public IResult Delete(PrescriptionMedicine PrescriptionMedicine)
        {
            _prescriptionMedicineDal.Delete(PrescriptionMedicine);
            return new SuccessResult(Messages.PrescriptionMedicineDeleted);
        }
        public IResult Update(PrescriptionMedicine PrescriptionMedicine)
        {
            _prescriptionMedicineDal.Update(PrescriptionMedicine);
            return new SuccessResult(Messages.PrescriptionMedicineDeleted);
        }

        public IDataResult<PrescriptionMedicine> GetById(int id)
        {
            return new SuccessDataResult<PrescriptionMedicine>(_prescriptionMedicineDal.Get(a => a.Id == id));
        }

        public IDataResult<List<PrescriptionMedicine>> GetList()
        {
            return new SuccessDataResult<List<PrescriptionMedicine>>(_prescriptionMedicineDal.GetList().ToList(), Messages.PrescriptionMedicineListed);
        }
    }
}
