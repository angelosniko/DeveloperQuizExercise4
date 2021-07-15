using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class BeerRatingDto
    {
        public Guid ID { get; set; }

        public Guid BeerId { get; set; }
        [Range(1, 5)]
        public int BeerRatingValue { get; set; }



    }
}
