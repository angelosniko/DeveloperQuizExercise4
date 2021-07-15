using API.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CourseLibrary.API.Entities
{
    public class Beer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string BeerName { get; set; }

        [Required]
        [MaxLength(50)]
        public string BeerType { get; set; }
       

        public ICollection<BeerRating> BeerRatings { get; set; }
            = new List<BeerRating>();
        //https://stackoverflow.com/questions/50157236/average-rating-using-two-views-in-entity-framework-asp-net-core

       }
}
