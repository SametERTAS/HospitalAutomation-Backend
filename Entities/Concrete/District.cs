using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class District :Area
    {
        public int CityId { get; set; }    // FK
    }
}
