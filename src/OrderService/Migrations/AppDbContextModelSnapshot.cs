﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderService.ApplicationDbContext;

#nullable disable

namespace OrderService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OrderService.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5219),
                            CustomerId = 1,
                            OrderDate = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5214),
                            ProductId = 1,
                            Quantity = 0,
                            Status = true,
                            TotalPrice = 100m
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5252),
                            CustomerId = 1,
                            OrderDate = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5250),
                            ProductId = 2,
                            Quantity = 0,
                            Status = true,
                            TotalPrice = 200m
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5254),
                            CustomerId = 2,
                            OrderDate = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5253),
                            ProductId = 3,
                            Quantity = 0,
                            Status = true,
                            TotalPrice = 300m
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5256),
                            CustomerId = 3,
                            OrderDate = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5255),
                            ProductId = 4,
                            Quantity = 0,
                            Status = true,
                            TotalPrice = 400m
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5257),
                            CustomerId = 4,
                            OrderDate = new DateTime(2023, 10, 6, 12, 55, 28, 966, DateTimeKind.Utc).AddTicks(5256),
                            ProductId = 1,
                            Quantity = 0,
                            Status = true,
                            TotalPrice = 500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
