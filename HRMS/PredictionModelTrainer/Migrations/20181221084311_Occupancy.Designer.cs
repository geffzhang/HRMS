﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PredictionModelTrainer;

namespace PredictionModelTrainer.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20181221084311_Occupancy")]
    partial class Occupancy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PredictionModelTrainer.Occupancy", b =>
                {
                    b.Property<int>("DailyOccupancyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdultNo");

                    b.Property<int>("Arriving");

                    b.Property<int>("AssignedReservation");

                    b.Property<int>("ChildrenNo");

                    b.Property<int>("Complimentary");

                    b.Property<DateTime>("Date");

                    b.Property<int>("DayUse");

                    b.Property<int>("Departing");

                    b.Property<int>("Inhouse");

                    b.Property<int>("NoShow");

                    b.Property<int>("ReservationNo");

                    b.Property<int>("RoomInventory");

                    b.Property<int>("RoomOccupied");

                    b.Property<int>("RoomSold");

                    b.Property<int>("Tentative");

                    b.Property<int>("TentativeCancellation");

                    b.Property<int>("TotalCancellation");

                    b.Property<int>("TotalRoom");

                    b.Property<int>("UnassignedReservation");

                    b.Property<int>("Unavailable");

                    b.Property<int>("UserCancellation");

                    b.Property<int>("VacantRoom");

                    b.Property<int>("Vip");

                    b.HasKey("DailyOccupancyId");

                    b.ToTable("Occupancy");
                });

            modelBuilder.Entity("PredictionModelTrainer.RoomRates", b =>
                {
                    b.Property<int>("DailyRoomRateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountTypeExclusive");

                    b.Property<int>("AmountTypeInclusive");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Iscomplimentary");

                    b.Property<string>("RateCode");

                    b.Property<int>("RateCodeId");

                    b.Property<bool>("RoomRateIsSet");

                    b.Property<string>("RoomTypeCode");

                    b.Property<int>("RoomTypeId");

                    b.Property<int>("TaxAmount");

                    b.HasKey("DailyRoomRateId");

                    b.ToTable("RoomRates");
                });
#pragma warning restore 612, 618
        }
    }
}
