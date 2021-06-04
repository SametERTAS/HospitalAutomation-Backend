using Business.Abstract;
using Business.Constants;
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
    public class MedicineManager :IMedicineService
    {
        private IMedicineDal _medicineDal;

        public MedicineManager(IMedicineDal medicineDal)
        {
            _medicineDal = medicineDal;
        }

        public IResult Add(Medicine medicine)
        {
            _medicineDal.Add(medicine);
            return new SuccessResult(Messages.MedicineCreated);
        }

        public IResult Delete(Medicine Medicine)
        {
            _medicineDal.Delete(Medicine);
            return new SuccessResult(Messages.MedicineDeleted);
        }
        public IResult Update(Medicine Medicine)
        {
            _medicineDal.Update(Medicine);
            return new SuccessResult(Messages.MedicineDeleted);
        }

        public IDataResult<Medicine> GetById(int id)
        {
            return new SuccessDataResult<Medicine>(_medicineDal.Get(a => a.Id == id));
        }

        public IDataResult<List<Medicine>> GetList()
        {
            return new SuccessDataResult<List<Medicine>>(_medicineDal.GetList().ToList(), Messages.MedicineListed);
        }
    }
}
