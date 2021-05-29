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
    public class HospitalClinicManager : IHospitalClinicService
    {
        private IHospitalClinicDal _hospitalClinicDal;
        public HospitalClinicManager(IHospitalClinicDal hospitalClinicDal)
        {
            _hospitalClinicDal = hospitalClinicDal;
        }
        public IResult Add(HospitalClinic hospitalClinic)
        {
            _hospitalClinicDal.Add(hospitalClinic);
            return new SuccessResult(Messages.HospitalClinicCreated);
        }

        public IResult Delete(HospitalClinic hospitalClinic)
        {
            _hospitalClinicDal.Delete(hospitalClinic);
            return new SuccessResult(Messages.HospitalClinicDeleted);
        }

        public IDataResult<HospitalClinic> GetById(int id)
        {
            return new SuccessDataResult<HospitalClinic>(_hospitalClinicDal.Get(e => e.Id == id));
        }

        public IDataResult<List<HospitalClinic>> GetList()
        {
            return new SuccessDataResult<List<HospitalClinic>>(_hospitalClinicDal.GetList().ToList(), Messages.HospitalClinicListed);
        }

        public IResult Update(HospitalClinic hospitalClinic)
        {
            _hospitalClinicDal.Update(hospitalClinic);
            return new SuccessResult(Messages.HospitalClinicUpdated);
        }
    }
}
