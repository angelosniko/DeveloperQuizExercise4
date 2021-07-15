using CourseLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class BeerRating
    {

        [Key]
        public Guid ID { get; set; }
       
        public Guid BeerId { get; set; }


        [ForeignKey("BeerId")]
        public Beer Beer { get; set; }

            

     
        [Range(1, 5)]
        public int? BeerRatingValue{get; set; }


  

    }
}
