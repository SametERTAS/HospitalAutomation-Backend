using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Area : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneCode { get; set; }
        public DateTime CreatedDate { get; set ; }
        public bool IsActive { get ; set ; }
    }
}
