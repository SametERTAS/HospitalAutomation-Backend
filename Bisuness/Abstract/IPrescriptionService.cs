using Core.Utilities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bisuness.Abstract
{
    public interface IPrescriptionService
    {
        IDataResult<List<Prescription>> GetList();
        IDataResult<Prescription> GetById(int id);
        IResult Add(Prescription prescription);
        IResult Update(Prescription prescription);
        IResult Delete(Prescription prescription);
    }

}
