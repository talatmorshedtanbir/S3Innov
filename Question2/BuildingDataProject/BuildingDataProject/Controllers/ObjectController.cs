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
    public class ObjectController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IObjectService _objectService;
        public ObjectController(IConfiguration configuration, IObjectService objectService)
        {
            _configuration = configuration;
            _objectService = objectService;
        }

        [HttpGet("getobjects")]
        public IActionResult Get()
        {
            var objects = _objectService.GetObjects();

            var result = new
            {
                statusCode = 200,
                success = true,
                data = objects
            };

            return Ok(result);
        }
    }
}
