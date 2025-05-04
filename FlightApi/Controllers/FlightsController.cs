using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlightApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;

        //Dependency Injection below
        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }
    }
}
