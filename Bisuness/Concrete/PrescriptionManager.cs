using Business.Abstract;
using Business.Contants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PrescriptionManager : IPrescriptionService
    {
        private IPrescriptionDal _prescriptionDal;

        public PrescriptionManager(IPrescriptionDal prescriptionDal)
        {
            _prescriptionDal = prescriptionDal;
        }

        public IResult Add(Prescription prescription)
        {
            _prescriptionDal.Add(prescription);
            return new SuccessResult(Messages.PrescriptionCreated);
        }

        public IResult Delete(Prescription Prescription)
        {
            _prescriptionDal.Delete(Prescription);
            return new SuccessResult(Messages.PrescriptionDeleted);
        }
        public IResult Update(Prescription Prescription)
        {
            _prescriptionDal.Update(Prescription);
            return new SuccessResult(Messages.PrescriptionDeleted);
        }

        public IDataResult<Prescription> GetById(int id)
        {
            return new SuccessDataResult<Prescription>(_prescriptionDal.Get(a => a.Id == id));
        }

        public IDataResult<List<Prescription>> GetList()
        {
            return new SuccessDataResult<List<Prescription>>(_prescriptionDal.GetList().ToList(), Messages.PrescriptionListed);
        }
    }
}
