using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightApi.Model;
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

        [HttpGet]
        public ActionResult<List<Flight>> GetAllFlights()
        {
            return Ok(_flightService.GetAllFlights());
        }

        [HttpGet("{id}")]
        public ActionResult<Flight> GetFlightById(int id)
        {
            var result = _flightService.GetFlightById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<Flight> CreateFlight(Flight flight)
        {
            return Ok(_flightService.CreateFlight(flight));
        }

        [HttpPut("{id}")]
        public ActionResult<Flight> UpdateFlight(int id, Flight updatedFlight)
        {
            var result = _flightService.GetFlightById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteFlight (int id)
        {
            var result = _flightService.GetFlightById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
