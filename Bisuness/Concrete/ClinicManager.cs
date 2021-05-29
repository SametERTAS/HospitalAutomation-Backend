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
    public class ClinicManager : IClinicService
    {
        private IClinicDal _clinicDal;
        public ClinicManager(IClinicDal clinicDal)
        {
            _clinicDal = clinicDal;
        }
        public IResult Add(Clinic clinic)
        {
            _clinicDal.Add(clinic);
            return new SuccessResult(Messages.ClinicCreated);

        }

        public IResult Delete(Clinic clinic)
        {
            _clinicDal.Delete(clinic);
            return new SuccessResult(Messages.ClinicDeleted);
        }
        public IResult Update(Clinic clinic)
        {
            _clinicDal.Update(clinic);
            return new SuccessResult(Messages.ClinicUpdated);
        }
        public IDataResult<Clinic> GetByName(string name)
        {
            return new SuccessDataResult<Clinic>(_clinicDal.Get(c => c.Name.ToLower().Contains(name.ToLower())));
        }

        public IDataResult<List<Clinic>> GetList()
        {
            return new SuccessDataResult<List<Clinic>>(_clinicDal.GetList().ToList(),Messages.ClinicListed);
        }


    }
}
