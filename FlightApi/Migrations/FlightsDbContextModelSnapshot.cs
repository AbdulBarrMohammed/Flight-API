﻿// <auto-generated />
using System;
using FlightApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightApi.Data.Migrations
{
    [DbContext(typeof(FlightsDbContext))]
    partial class FlightsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("FlightApi.Model.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AirlineName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArrivalAirportCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartureAirportCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("FlightNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassengerCapacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
