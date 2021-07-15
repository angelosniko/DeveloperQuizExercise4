using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Profiles
{
    public class BeersProfile :Profile
    {
        public BeersProfile() {
            CreateMap<CourseLibrary.API.Entities.Beer, Models.BeerDto>()
                    .ForMember(
                dest => dest.BeerName,
                opt => opt.MapFrom(src => src.BeerName)
                )
                    .ForMember(
                dest => dest.BeerType,
                opt => opt.MapFrom(src => src.BeerType)

                );
            CreateMap<Models.BeerForCreationDto, CourseLibrary.API.Entities.Beer>();
            CreateMap<Models.BeerForUpdateDto, CourseLibrary.API.Entities.Beer>();

        }
    }
}
