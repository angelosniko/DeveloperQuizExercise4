﻿// <auto-generated />
using System;
using CourseLibrary.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(BeerLibraryContext))]
    [Migration("20210628105332_MyAverageMigration")]
    partial class MyAverageMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Entities.BeerRating", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BeerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BeerRatingValue")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BeerId");

                    b.ToTable("BeerRatings");

                    b.HasData(
                        new
                        {
                            ID = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            BeerId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            BeerRatingValue = 1
                        },
                        new
                        {
                            ID = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            BeerId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            BeerRatingValue = 2
                        },
                        new
                        {
                            ID = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            BeerId = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            BeerRatingValue = 2
                        },
                        new
                        {
                            ID = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            BeerId = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            BeerRatingValue = 3
                        });
                });

            modelBuilder.Entity("CourseLibrary.API.Entities.Beer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BeerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BeerType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GetAverage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Beers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            BeerName = "Berry",
                            BeerType = "Griffin Beak Eldritch",
                            GetAverage = 0
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            BeerName = "Nancy",
                            BeerType = "Swashbuckler Rye",
                            GetAverage = 0
                        },
                        new
                        {
                            Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            BeerName = "Eli",
                            BeerType = "Ivory Bones Sweet",
                            GetAverage = 0
                        },
                        new
                        {
                            Id = new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                            BeerName = "Arnold",
                            BeerType = "The Unseen Stafford",
                            GetAverage = 0
                        },
                        new
                        {
                            Id = new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                            BeerName = "Seabury",
                            BeerType = "Toxic Reyson",
                            GetAverage = 0
                        },
                        new
                        {
                            Id = new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                            BeerName = "Rutherford",
                            BeerType = "Fearless Cloven",
                            GetAverage = 0
                        },
                        new
                        {
                            Id = new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                            BeerName = "Atherton",
                            BeerType = "Crow Ridley",
                            GetAverage = 0
                        });
                });

            modelBuilder.Entity("API.Entities.BeerRating", b =>
                {
                    b.HasOne("CourseLibrary.API.Entities.Beer", "Beer")
                        .WithMany("BeerRatings")
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beer");
                });

            modelBuilder.Entity("CourseLibrary.API.Entities.Beer", b =>
                {
                    b.Navigation("BeerRatings");
                });
#pragma warning restore 612, 618
        }
    }
}