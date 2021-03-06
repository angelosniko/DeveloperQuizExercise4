// <auto-generated />
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
    [Migration("20210622064554_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<Guid?>("BeerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BeerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("BeerRating")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("BeerType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BeerId");

                    b.ToTable("Beers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            BeerName = "Berry",
                            BeerRating = 1,
                            BeerType = "Griffin Beak Eldritch"
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            BeerName = "Nancy",
                            BeerRating = 2,
                            BeerType = "Swashbuckler Rye"
                        },
                        new
                        {
                            Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            BeerName = "Eli",
                            BeerRating = 3,
                            BeerType = "Ivory Bones Sweet"
                        },
                        new
                        {
                            Id = new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                            BeerName = "Arnold",
                            BeerRating = 4,
                            BeerType = "The Unseen Stafford"
                        },
                        new
                        {
                            Id = new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                            BeerName = "Seabury",
                            BeerRating = 5,
                            BeerType = "Toxic Reyson"
                        },
                        new
                        {
                            Id = new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                            BeerName = "Rutherford",
                            BeerRating = 4,
                            BeerType = "Fearless Cloven"
                        },
                        new
                        {
                            Id = new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                            BeerName = "Atherton",
                            BeerRating = 2,
                            BeerType = "Crow Ridley"
                        });
                });

            modelBuilder.Entity("CourseLibrary.API.Entities.Beer", b =>
                {
                    b.HasOne("CourseLibrary.API.Entities.Beer", null)
                        .WithMany("BeerList")
                        .HasForeignKey("BeerId");
                });

            modelBuilder.Entity("CourseLibrary.API.Entities.Beer", b =>
                {
                    b.Navigation("BeerList");
                });
#pragma warning restore 612, 618
        }
    }
}
