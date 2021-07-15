using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class BeerDto
    {

        public Guid Id { get; set; }

        public string BeerName { get; set; }

        public string BeerType { get; set; }

        public double? Rating { get; set; }


    }
}
