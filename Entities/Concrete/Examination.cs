using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Examination : IEntity
    {
        public DateTime CreatedDate { get ; set ; }
        public bool IsActive { get; set ; }
        public int Id { get; set; }
        public string Diagnosis { get; set; }
        public int AppointmentId { get; set; }
    }
}
