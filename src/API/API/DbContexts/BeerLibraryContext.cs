using API.Entities;
using CourseLibrary.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CourseLibrary.API.DbContexts
{
    public class BeerLibraryContext : DbContext
    {
        public BeerLibraryContext(DbContextOptions<BeerLibraryContext> options)
           : base(options)
        {
        }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<BeerRating> BeerRatings { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Beer>().HasData(
                new Beer()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    BeerName = "Berry",
                    BeerType = "Griffin Beak Eldritch",
            
                    
                },
                new Beer()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    BeerName = "Nancy",
                    BeerType = "Swashbuckler Rye",
                  
                   
                },
                new Beer()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    BeerName = "Eli",
                    BeerType = "Ivory Bones Sweet",
                    
                    
                },
                new Beer()
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    BeerName = "Arnold",
                    BeerType = "The Unseen Stafford",
                    
                   
                },
                new Beer()
                {
                    Id = Guid.Parse("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                    BeerName = "Seabury",
                    BeerType = "Toxic Reyson",
                    
                    
                },
                new Beer()
                {
                    Id = Guid.Parse("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                    BeerName = "Rutherford",
                    BeerType = "Fearless Cloven",
                    
                },
                new Beer()
                {
                    Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                    BeerName = "Atherton",
                    BeerType = "Crow Ridley",
                    
                }
                );

            modelBuilder.Entity<BeerRating>().HasData(
                new BeerRating
                {

                    ID = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                    BeerId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    BeerRatingValue = 1


                },
                new BeerRating {

                 
                    ID = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                    BeerId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    BeerRatingValue = 2

                },
                   new BeerRating
                   {


                       ID = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                       BeerId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                       BeerRatingValue = 2

                   },
                        new BeerRating
                        {


                            ID = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            BeerId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                            BeerRatingValue = 3

                        }


                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
