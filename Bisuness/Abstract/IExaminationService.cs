using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bisuness.Abstract
{
    public interface IExaminationService
    {
        IDataResult<List<Examination>> GetList();
        IDataResult<Examination> GetById(int id);
        IResult Add(Examination examination);
        IResult Update(Examination examination);
        IResult Delete(Examination examination);
    }

}
