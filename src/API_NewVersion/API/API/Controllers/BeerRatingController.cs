using API.Models;
using AutoMapper;
using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/beers/{beerId}/BeerRating")]
    public class BeerRatingController : ControllerBase
    {
        private readonly IBeerLibraryRepository _beerLibrayRepository;
        private readonly IMapper _mapper;


        public BeerRatingController(IBeerLibraryRepository beerLibrayRepository, IMapper mapper)
        {
            _beerLibrayRepository = beerLibrayRepository ??
                throw new ArgumentNullException(nameof(beerLibrayRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));


        }
        [HttpGet]
        public ActionResult<IEnumerable<BeerRatingDto>> GetRatingsForBeer(Guid beerId) {

            if (!_beerLibrayRepository.BeerExists(beerId)) {

                return NotFound();
            }

            var beerRatingForBeerFromRepo = _beerLibrayRepository.GetBeerRatings(beerId);
            return Ok(_mapper.Map<IEnumerable<BeerRatingDto>>(beerRatingForBeerFromRepo));


        }







        [HttpGet("{beerRatingId}", Name = "GetRatingForBeer")]
        public ActionResult<BeerRatingDto> GetRatingForBeer(Guid beerId, Guid beerRatingID)
        {
            if (!_beerLibrayRepository.BeerExists(beerId)) { return NotFound(); }

            var beerRatignForBeerFromRepo = _beerLibrayRepository.GetBeerRating(beerId, beerRatingID);
            if (beerRatignForBeerFromRepo == null) { return NotFound(); }
            return Ok(_mapper.Map<BeerRatingDto>(beerRatignForBeerFromRepo));

        }



        [HttpPost]
        public ActionResult<BeerRatingDto> CreateRatingForBeer(Guid beerId, BeerRatingForCreationDto beerRating)
        {
            if (!_beerLibrayRepository.BeerExists(beerId)) { return NotFound(); }

            var beerRatingEntity = _mapper.Map<Entities.BeerRating>(beerRating);
            _beerLibrayRepository.AddBeerRating(beerId, beerRatingEntity);
            _beerLibrayRepository.Save();


            var beerRatingToReturn = _mapper.Map<BeerRatingDto>(beerRatingEntity);
            return Ok(beerRatingToReturn);



        }

    





        [HttpPut("{beerRatingId}")]
        public ActionResult UpdateBeerRatingForBeer(Guid beerId,
            Guid beerRatingId,
            BeerRatingForUpdateDto beerRating
            )
        {

            if (!_beerLibrayRepository.BeerExists(beerId))
            {

                return NotFound();
            }

            var beerFromRepo = _beerLibrayRepository.GetBeerRating(beerId, beerRatingId);


            if (beerFromRepo == null)
            {


                var beerRatingtoadd = _mapper.Map<Entities.BeerRating>(beerRating);
                beerRatingtoadd.ID = beerId;
                _beerLibrayRepository.AddBeerRating(beerId, beerRatingtoadd);
                _beerLibrayRepository.Save();
                var beerRatingToReturn = _mapper.Map<BeerRatingDto>(beerRatingtoadd);
                return CreatedAtRoute("GetBeerRatingForBeer", new
                {
                    beerId = beerId,
                    beerRatingId = beerRatingToReturn.BeerId
                },
                beerRatingToReturn);
            }



            _mapper.Map(beerRating, beerFromRepo);
            _beerLibrayRepository.UpdateBeerRating(beerFromRepo);
            _beerLibrayRepository.Save();
            return NoContent();

        }


    }

}

