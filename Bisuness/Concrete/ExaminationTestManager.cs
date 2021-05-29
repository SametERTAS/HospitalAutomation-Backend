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
    public class ExaminationTestManager : IExaminationTestService
    {
        private IExaminationTestDal _examinationTestDal;

        public ExaminationTestManager(IExaminationTestDal examinationTestDal)
        {
            _examinationTestDal = examinationTestDal;
        }

        public IResult Add(ExaminationTest examinationTest)
        {
            _examinationTestDal.Add(examinationTest);
            return new SuccessResult(Messages.ExaminationTestCreated);
        }

        public IResult Delete(ExaminationTest ExaminationTest)
        {
            _examinationTestDal.Delete(ExaminationTest);
            return new SuccessResult(Messages.ExaminationTestDeleted);
        }
        public IResult Update(ExaminationTest ExaminationTest)
        {
            _examinationTestDal.Update(ExaminationTest);
            return new SuccessResult(Messages.ExaminationTestDeleted);
        }

        public IDataResult<ExaminationTest> GetById(int id)
        {
            return new SuccessDataResult<ExaminationTest>(_examinationTestDal.Get(a => a.Id == id));
        }

        public IDataResult<List<ExaminationTest>> GetList()
        {
            return new SuccessDataResult<List<ExaminationTest>>(_examinationTestDal.GetList().ToList(), Messages.ExaminationTestListed);
        }
    }
}
