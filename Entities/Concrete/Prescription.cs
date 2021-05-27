using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Prescription : IEntity
    {
        public int Id { get; set; }
        public string PrescriptionNumber { get; set; }
        public DateTime DateTime { get; set; }
        public int ExaminationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
