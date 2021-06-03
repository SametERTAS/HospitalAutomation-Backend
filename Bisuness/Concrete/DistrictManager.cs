using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        private IDistrictDal _districtDal;
        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }
        public IResult Add(District district)
        {
            _districtDal.Add(district);
            return new SuccessResult(Messages.DistrictCreated);
        }

        public IResult Delete(District district)
        {
            _districtDal.Delete(district);
            return new SuccessResult(Messages.DistrictDeleted);
        }

        public IDataResult<District> GetByPhoneCode(int phoneCode)
        {
            return new SuccessDataResult<District>(_districtDal.Get(d => d.PhoneCode == phoneCode));
        }

        public IDataResult<List<District>> GetList()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetList().ToList(), Messages.DistrictListed);
        }

        public IResult Update(District district)
        {
            _districtDal.Update(district);
            return new SuccessResult(Messages.DistrictUpdated);
        }
    }
}
