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
    public class FactoryLocationController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<FactoryCity> Get()
        {
            return new FactoryCity [] {
                new FactoryCity("Beijing"),
                new FactoryCity("Hong Kong"),
                new FactoryCity("Johannesburg"),
                new FactoryCity("London"),
                new FactoryCity("Mexico City"),
                new FactoryCity("Miami"),
                new FactoryCity("Milan"),
                new FactoryCity("Paris"),
                new FactoryCity("Rio de Janeiro"),
                new FactoryCity("Seattle"),
                new FactoryCity("Seoul"),
                new FactoryCity("Stockholm"),
                new FactoryCity("Sydney"),
                new FactoryCity("Tokyo"),
                new FactoryCity("Toronto"),
            };
        }
    }
}
