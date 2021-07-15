using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class BeerRatingDto
    {
        public Guid ID { get; set; }

        public Guid BeerId { get; set; }

        public int BeerRatingValue { get; set; }



    }
}
