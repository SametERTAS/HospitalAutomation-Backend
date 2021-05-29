using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IExaminationTestService
    {
        IDataResult<List<ExaminationTest>> GetList();
        IDataResult<ExaminationTest> GetById(int id);
        IResult Add(ExaminationTest examinationTest);
        IResult Update(ExaminationTest examinationTest);
        IResult Delete(ExaminationTest examinationTest);
    }

}
