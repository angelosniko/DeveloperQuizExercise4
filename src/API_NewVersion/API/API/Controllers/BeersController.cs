using API.Entities;
using API.Models;
using AutoMapper;
using CourseLibrary.API.Entities;
using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{

    [ApiController]
    [Route("api/beers")]
   
  
    public class BeersController : ControllerBase
    {
        private readonly IBeerLibraryRepository _beerLibraryRepository;
        private readonly IMapper _mapper;

        public BeersController(IBeerLibraryRepository beerLibraryRepository,IMapper mapper) {

            _beerLibraryRepository = beerLibraryRepository ??
                    throw new ArgumentNullException(nameof(beerLibraryRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        
        }

        [HttpGet()]
        [HttpHead]
        public ActionResult<IEnumerable<BeerDto>> GetBeers(string beerName)
        {
            
            var beersFromRepo = _beerLibraryRepository.GetBeers(beerName);
            var beers = new List<BeerDto>();

            foreach (var beerFromRepo in beersFromRepo) {
                var beer = new BeerDto()
                {
                    Id = beerFromRepo.Id,
                    BeerName = beerFromRepo.BeerName,
                    BeerType = beerFromRepo.BeerType,
                    Rating = beerFromRepo.BeerRatings.Select(g => g.BeerRatingValue).Average()
                };
                beers.Add(beer);
            }


            return Ok(beers);



        }


        //[HttpGet("{beerId}", Name = "GetBeer")]
        //public IActionResult GetBeer(Guid beerId)
        //{

        //    if (!_beerLibraryRepository.BeerExists(beerId))
        //    {
        //        return NotFound();
        //    }


        //    var beerFromRepo = _beerLibraryRepository.GetBeer(beerId);
        //    return Ok(_mapper.Map<BeerDto>(beerFromRepo));


        //}

        [HttpGet("{beerId}")]
        public ActionResult<BeerDto> GetAverage(Guid beerId)
        {

            var beerFromRepo = _beerLibraryRepository.GetAverage(beerId);

            var beers = new BeerDto()
            {
                Id = beerFromRepo.Id,
                BeerName = beerFromRepo.BeerName,
                BeerType = beerFromRepo.BeerType,
                Rating = beerFromRepo.BeerRatings.Select(g => g.BeerRatingValue).Average()
            };

            return Ok(beers);

           }



        [HttpPost]
        public ActionResult<BeerDto> CreateBeer(BeerForCreationDto beer) {

             
            
            var beerEntity = _mapper.Map<Beer>(beer);
            _beerLibraryRepository.AddBeer(beerEntity);
            _beerLibraryRepository.Save();

            var beerToReturn = _mapper.Map<BeerDto>(beerEntity);
            return CreatedAtRoute("GetBeer",
                new { beerId=beerToReturn.Id},
                beerToReturn
                );
        
        }

        [HttpPut("{beerId}")]

        public ActionResult UpdateBeer(Guid beerId, BeerForUpdateDto beer
            ) {

            if (!_beerLibraryRepository.BeerExists(beerId))
            {

                return NotFound();
            }

            var beerFromRepo = _beerLibraryRepository.GetBeer(beerId);

            
            

            _mapper.Map(beer, beerFromRepo);

            _beerLibraryRepository.UpdateBeer(beerFromRepo);
            

            _beerLibraryRepository.Save();
            return Content("Beer Details updated");
        }



    }
}
