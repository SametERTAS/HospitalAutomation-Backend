using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class deneme : ControllerBase
    {
        EfUserDal aa = new EfUserDal();
        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            aa.Add(user);
            return Ok();
        }
    }
}
