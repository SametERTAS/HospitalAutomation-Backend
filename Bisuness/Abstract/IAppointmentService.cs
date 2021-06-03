using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        IDataResult<List<Appointment>> GetList();
        IDataResult<Appointment> GetById(int id);
        IResult Add(Appointment appointment);
        IResult Update(Appointment appointment);
        IResult Delete(Appointment appointment);
    }

}
