using API.Entities;
using CourseLibrary.API.Entities;
using System;
using System.Collections.Generic;

namespace CourseLibrary.API.Services
{
    public interface IBeerLibraryRepository
    {
        IEnumerable<BeerRating> GetBeerRatings(Guid beerId);
        BeerRating GetBeerRating(Guid beerId, Guid ID);
        void AddBeerRating(Guid beerId, BeerRating beerRating);
        void UpdateBeerRating(BeerRating beerRating);


        IEnumerable<Beer> GetBeers();
        Beer GetBeer(Guid BeerId);
        IEnumerable<Beer> GetBeers(IEnumerable<Guid> BeerIds);
        public Beer GetAverage(Guid beerId);

        public IEnumerable<Beer> GetBeers(string beerName);

        void AddBeer(Beer beer);
        void DeleteBeer(Beer beer);
        void UpdateBeer(Beer beer);
        bool BeerExists(Guid beerId);
        bool Save();
       
    }
}
