using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Profiles
{
    public class BeerRatingProfile :Profile
    {

        public BeerRatingProfile() {

            CreateMap<Entities.BeerRating, Models.BeerRatingDto>();
            CreateMap<Models.BeerRatingForCreationDto, Entities.BeerRating>();
            CreateMap<Models.BeerRatingForUpdateDto, Entities.BeerRating>();
        
        }
    }
}
