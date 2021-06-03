using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Business.Contants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;

namespace Business.Concrete
{
    public class ExaminationManager : IExaminationService
    {
        private IExaminationDal _examinationDal;
        public ExaminationManager(IExaminationDal examinationDal)
        {
            _examinationDal = examinationDal;
        }
        public IResult Add(Examination examination)
        {
            _examinationDal.Add(examination);
            return new SuccessResult(Messages.ExaminationCreated);
        }

        public IResult Delete(Examination examination)
        {
            _examinationDal.Delete(examination);
            return new SuccessResult(Messages.ExaminationDeleted);
        }

        public IDataResult<Examination> GetById(int id)
        {
            return new SuccessDataResult<Examination>(_examinationDal.Get(e => e.Id == id));
        }

        public IDataResult<List<Examination>> GetList()
        {
            return new SuccessDataResult<List<Examination>>(_examinationDal.GetList().ToList(), Messages.ExaminationListed);
        }

        public IResult Update(Examination examination)
        {
            _examinationDal.Update(examination);
            return new SuccessResult(Messages.ExaminationUpdated);
        }
    }
}
