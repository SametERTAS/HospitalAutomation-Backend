using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security
{
    public class AccessToken
    {
        public string Token { get; set; }                                      // Token
        public DateTime Expiration { get; set; }                               // Time that how many time it is available for token

    }
}
