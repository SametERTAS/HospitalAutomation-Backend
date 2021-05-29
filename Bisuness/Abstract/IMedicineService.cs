using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMedicineService
    {
        IDataResult<List<Medicine>> GetList();
        IDataResult<Medicine> GetById(int id);
        IResult Add(Medicine medicine);
        IResult Update(Medicine medicine);
        IResult Delete(Medicine medicine);
    }

}
