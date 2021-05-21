using BuildingDataProject.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingDataProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataFieldController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IDataFieldService _dataFieldService;
        public DataFieldController(IConfiguration configuration, IDataFieldService dataFieldService)
        {
            _configuration = configuration;
            _dataFieldService = dataFieldService;
        }

        [HttpGet("getdatafields")]
        public IActionResult Get()
        {
            var dataFields = _dataFieldService.GetDataFields();

            var result = new
            {
                statusCode = 200,
                success = true,
                data = dataFields
            };

            return Ok(result);
        }
    }
}
