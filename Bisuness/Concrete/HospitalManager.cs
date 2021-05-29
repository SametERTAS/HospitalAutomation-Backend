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
    public class HospitalManager :IHospitalService
    {
        private IHospitalDal _hospitalDal;

        public HospitalManager(IHospitalDal hospitalDal)
        {
            _hospitalDal = hospitalDal;
        }

        public IResult Add(Hospital hospital)
        {
            _hospitalDal.Add(hospital);
            return new SuccessResult(Messages.HospitalCreated);
        }

        public IResult Delete(Hospital Hospital)
        {
            _hospitalDal.Delete(Hospital);
            return new SuccessResult(Messages.HospitalDeleted);
        }
        public IResult Update(Hospital Hospital)
        {
            _hospitalDal.Update(Hospital);
            return new SuccessResult(Messages.HospitalDeleted);
        }

        public IDataResult<Hospital> GetById(int id)
        {
            return new SuccessDataResult<Hospital>(_hospitalDal.Get(a => a.Id == id));
        }

        public IDataResult<List<Hospital>> GetList()
        {
            return new SuccessDataResult<List<Hospital>>(_hospitalDal.GetList().ToList(), Messages.HospitalListed);
        }
    }
}
