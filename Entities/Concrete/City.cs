using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class City : Area
    {
        public int CountryId { get; set; }   // FK
        public int PlateCode { get; set; }
        
    }
}
