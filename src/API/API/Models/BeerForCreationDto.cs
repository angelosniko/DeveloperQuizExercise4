using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class BeerForCreationDto 
    {

    

        public Guid Id { get; set; }

        
        public string BeerName { get; set; }

     
        public string BeerType { get; set; }

        public ICollection<BeerRatingForCreationDto> BeerRatings { get; set; }
            = new List<BeerRatingForCreationDto>();

        



        

          
        

    
    }
}
