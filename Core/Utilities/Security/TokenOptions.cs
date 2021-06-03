using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security
{
    public class TokenOptions
    {
        public string Audience { get; set; }                                  // kullanıcı kitlesi
        public string Issuer { get; set; }                                    // imzalayan ?
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}


/*
 
 these props will be coming from appsetting in WebAPI, we wanted not doing hard code. we are gonna set these props from appsetting and work with that class 
 
 */