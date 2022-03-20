using Fluent_Validation_.Net_Core_5.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fluent_Validation_.Net_Core_5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        // POST api/<CompanyController>
        [HttpPost]
        public Company Post([FromBody] Company company)
        {
            return company;
        }
    }
}
