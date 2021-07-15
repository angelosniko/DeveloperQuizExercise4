using API.Entities;
using CourseLibrary.API.DbContexts;
using CourseLibrary.API.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseLibrary.API.Services
{
    public class BeerLibraryRepository : IBeerLibraryRepository, IDisposable
    {
        private readonly BeerLibraryContext _context;

        public BeerLibraryRepository(BeerLibraryContext context )
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

       

        public void AddBeer(Beer beer)
        {
            if (beer == null)
            {
                throw new ArgumentNullException(nameof(beer));
            }

            // the repository fills the id (instead of using identity columns)
            beer.Id = Guid.NewGuid();

            foreach (var beerRating in beer.BeerRatings)
            {
                beerRating.ID = Guid.NewGuid();

            }


            _context.Beers.Add(beer);
        }

        public bool BeerExists(Guid beerId)
        {
            if (beerId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(beerId));
            }

            return _context.Beers.Any(a => a.Id == beerId);
        }

        public void DeleteBeer(Beer beer)
        {
            if (beer == null)
            {
                throw new ArgumentNullException(nameof(beer));
            }

            _context.Beers.Remove(beer);
        }
        
        public Beer GetBeer(Guid beerId)
        {
            if (beerId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(beerId));
            }

            return _context.Beers.FirstOrDefault(a => a.Id == beerId);
        }

        ////https://stackoverflow.com/questions/65610856/ef-core-how-to-best-get-average-value-in-a-model-of-a-related-model

               



        public void AddBeerRating(Guid beerId, BeerRating beerRating)
        {
            if (beerId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(beerId));
            }

            if (beerRating == null)
            {
                throw new ArgumentNullException(nameof(beerRating));
            }
            beerRating.BeerId = beerId;
            
            _context.BeerRatings.Add(beerRating);
        }

        public BeerRating GetBeerRating(Guid beerId, Guid beerRatingId)
        {
            if (beerId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(beerId));
            }

            if (beerRatingId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(beerRatingId));
            }

            return _context.BeerRatings
              .Where(c => c.BeerId == beerId && c.ID == beerRatingId).FirstOrDefault();
        }

        public IEnumerable<BeerRating> GetBeerRatings(Guid beerId)
        {
            if (beerId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(beerId));
            }
            


            return _context.BeerRatings
                        
                        .Where(c => c.BeerId == beerId)
                        .OrderBy(c => c.BeerId).ToList();
        }

        public void UpdateBeerRating(BeerRating beerRating)
        {
            // no code in this implementation
        }



        public IEnumerable<Beer> GetBeers()
        {

            return _context.Beers.
                Include(b=>b.BeerRatings).ToList<Beer>();
        }


        public IEnumerable<Beer> GetBeers(string beerName)
        {
            if (string.IsNullOrWhiteSpace(beerName))
            {
                return GetBeers();

            }

            beerName = beerName.Trim();
            return _context.Beers.Where(a => a.BeerName == beerName).ToList();



        }






        public IEnumerable<Beer> GetBeers(IEnumerable<Guid> beerIds)
        {
            if (beerIds == null)
            {
                throw new ArgumentNullException(nameof(beerIds));
            }

            return (IEnumerable<Beer>)_context.Beers.Where(a => beerIds.Contains(a.Id))
                .OrderBy(a => a. BeerName)
                .OrderBy(a => a.BeerType)
                .Include(a => a.BeerRatings.Select(b => b.BeerRatingValue))
                .ToList();
                
        }

        public Beer GetAverage(Guid beerId) {
            var avg = _context.Beers
                .Where(p => p.Id == beerId)
                .Include(p => p.BeerRatings)
                .FirstOrDefault();
                

            return avg;
        }

    
            


     






        public void UpdateBeer(Beer beer)
        {
            // no code in this implementation
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
               // dispose resources when needed
            }
        }

     
        
     
    }
}
