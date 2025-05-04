using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightApi.Model;

namespace FlightApi.Services
{
    public interface IFlightService
    {
        public List<Flight> GetAllFlights();
        public Flight? GetFlightById(int id);
        public Flight CreateFlight(Flight flight);
        public Flight UpdateFlight(int id, Flight updatedFlight);
        public string? DeleteFlights(int id);
    }
}
