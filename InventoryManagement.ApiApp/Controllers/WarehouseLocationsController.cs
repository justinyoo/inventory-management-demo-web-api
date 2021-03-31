using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using InventoryManagement.ApiApp.Models;

namespace InventoryManagement.ApiApp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WarehouseLocationsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WarehouseCity> Get()
        {
            return new WarehouseCity [] {
                new WarehouseCity("Beijing"),
                new WarehouseCity("Hong Kong"),
                new WarehouseCity("Johannesburg"),
                new WarehouseCity("London"),
                new WarehouseCity("Mexico City"),
                new WarehouseCity("Miami"),
                new WarehouseCity("Milan"),
                new WarehouseCity("Paris"),
                new WarehouseCity("Rio de Janeiro"),
                new WarehouseCity("Seattle"),
                new WarehouseCity("Seoul"),
                new WarehouseCity("Stockholm"),
                new WarehouseCity("Sydney"),
                new WarehouseCity("Tokyo"),
                new WarehouseCity("Toronto"),
            };
        }
    }
}
