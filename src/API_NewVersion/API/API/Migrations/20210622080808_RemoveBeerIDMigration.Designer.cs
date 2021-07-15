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
    [Migration("20210622080808_RemoveBeerIDMigration")]
    partial class RemoveBeerIDMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseLibrary.API.Entities.Beer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BeerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("BeerRating")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<string>("BeerType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Beers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4ca8c3bb-7918-42b0-8051-ca693d28f854"),
                            BeerName = "Berry",
                            BeerRating = 1,
                            BeerType = "Griffin Beak Eldritch"
                        },
                        new
                        {
                            Id = new Guid("df96adac-3252-4ca9-a8d7-47a3e1fc8609"),
                            BeerName = "Nancy",
                            BeerRating = 2,
                            BeerType = "Swashbuckler Rye"
                        },
                        new
                        {
                            Id = new Guid("b8b72ec8-a901-477b-84d1-701b04676323"),
                            BeerName = "Eli",
                            BeerRating = 3,
                            BeerType = "Ivory Bones Sweet"
                        },
                        new
                        {
                            Id = new Guid("f3f7ce9f-4bcd-4c06-a0e8-455273cb8a6f"),
                            BeerName = "Arnold",
                            BeerRating = 4,
                            BeerType = "The Unseen Stafford"
                        },
                        new
                        {
                            Id = new Guid("741a0d2a-b7e1-4e42-b4d3-0af19e0c3022"),
                            BeerName = "Seabury",
                            BeerRating = 5,
                            BeerType = "Toxic Reyson"
                        },
                        new
                        {
                            Id = new Guid("af4009ac-aa42-43cb-8440-6a25b5178ad8"),
                            BeerName = "Rutherford",
                            BeerRating = 4,
                            BeerType = "Fearless Cloven"
                        },
                        new
                        {
                            Id = new Guid("ec47f4f8-207b-45e1-a161-e4f1ef62d5df"),
                            BeerName = "Atherton",
                            BeerRating = 2,
                            BeerType = "Crow Ridley"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}