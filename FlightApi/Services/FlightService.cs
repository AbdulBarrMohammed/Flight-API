using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightApi.Data;
using FlightApi.Model;


namespace FlightApi.Services
{
    public class FlightService : IFlightService
    {
        //
        private readonly FlightsDbContext _dbContext;

        // This is dependency injection
        public FlightService(FlightsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Flight CreateFlight(Flight flight)
        {
            throw new NotImplementedException();
        }

        public string? DeleteFlights(int id)
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetAllFlights()
        {
            throw new NotImplementedException();
        }

        public Flight? GetFlightById(int id)
        {
            throw new NotImplementedException();
        }

        public Flight UpdateFlight(int id, Flight updatedFlight)
        {
            throw new NotImplementedException();
        }
    }
}
