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
    public class TestManager :ITestService
    {
        private ITestDal _testDal;

        public TestManager(ITestDal testDal)
        {
            _testDal = testDal;
        }

        public IResult Add(Test test)
        {
            _testDal.Add(test);
            return new SuccessResult(Messages.TestCreated);
        }

        public IResult Delete(Test Test)
        {
            _testDal.Delete(Test);
            return new SuccessResult(Messages.TestDeleted);
        }
        public IResult Update(Test Test)
        {
            _testDal.Update(Test);
            return new SuccessResult(Messages.TestDeleted);
        }

        public IDataResult<Test> GetById(int id)
        {
            return new SuccessDataResult<Test>(_testDal.Get(a => a.Id == id));
        }

        public IDataResult<List<Test>> GetList()
        {
            return new SuccessDataResult<List<Test>>(_testDal.GetList().ToList(), Messages.TestListed);
        }
    }
}
