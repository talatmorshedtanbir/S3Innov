﻿using BuildingDataProject.Core.Entities;
using BuildingDataProject.Core.Services;
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
        private IBuildingService _buildingService;
        public BuildingController(IConfiguration configuration, IBuildingService buildingService)
        {
            _configuration = configuration;
            _buildingService = buildingService;
        }

        [HttpGet]
        public IEnumerable<Building> Get()
        {
            var buildings = _buildingService.GetBuildings();

            return buildings;
        }
    }
}
