using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITestService
    {
        IDataResult<List<Test>> GetList();
        IDataResult<Test> GetById(int id);
        IResult Add(Test test);
        IResult Update(Test test);
        IResult Delete(Test test);
    }

}
