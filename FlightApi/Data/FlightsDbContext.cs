using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightApi.Model;
using Microsoft.EntityFrameworkCore;

namespace FlightApi.Data
{
    public class FlightsDbContext : DbContext
    {
        public FlightsDbContext(DbContextOptions options) : base(options){}
        public DbSet<Flight> Flights { get; set; }
    }
}
