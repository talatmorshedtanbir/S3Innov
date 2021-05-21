using BuildingDataProject.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingDataProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<BuildingController> _logger;
        public BuildingController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Building> Get()
        {
            var buildings = new List<Building>() { 
                new Building(){ Id = 1, Location = "Dhk", Name = "Ant" },
                new Building(){ Id = 2, Location = "Dhk", Name = "Ant" }};
            return buildings;
        }
    }
}
