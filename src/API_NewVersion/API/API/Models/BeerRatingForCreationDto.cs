using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class BeerRatingForCreationDto
    {

        //public Guid BeerId { get; set; }
        [Range(1, 5)]
        public int BeerRatingValue { get; set; }

    }
}
