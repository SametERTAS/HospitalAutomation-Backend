using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
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
    public class CountriesController : ControllerBase
    {
        private ICountryService _countryService;
        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet]                                                                     // when you call just controller and get method
        [HttpGet("getall")]                                                           // when you call controller + this name "getall"
      //  [Authorize()]
        public IActionResult Get()
        {
            var result = _countryService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet]
        [HttpGet("getbyphonecode/{phonecode}")]                                        // it can be called like that methotName/parameterValue
        [HttpGet("getbyphonecode")]                                                    // it can be called like that method name?parameterName=parameterValue
        public IActionResult GetByPhoneCode(int phoneCode)
        {
            var result = _countryService.GetByPhoneCode(phoneCode);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]                                                             // bind controls that what has been given to action
                                                                                      // public IActionResult Add([Bind("Id,Name,PhoneCode")] Country country)
        public IActionResult Add(Country country)
        {
            var result = _countryService.Add(country);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]

        public IActionResult Update(Country country)
        {
            var result = _countryService.Update(country);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]

        public IActionResult Delete(Country country)
        {
            var result = _countryService.Delete(country);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
