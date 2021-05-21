using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingDataProject.Core.Services;

namespace BuildingDataProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IReadingService _readingService;
        public ReadingController(IConfiguration configuration, IReadingService readingService)
        {
            _configuration = configuration;
            _readingService = readingService;
        }

        [HttpGet("getreadings")]
        public IActionResult Get()
        {
            var readings = _readingService.GetReadings();

            var result = new
            {
                statusCode = 200,
                success = true,
                data = readings
            };

            return Ok(result);
        }
    }
}
