using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary
{
    public class SolarSystem : IDbEntity
    {
        public long? Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(5), MaxLength(20)]
        public string Name {get; set;}
        public virtual List<Planet> Planets { get; set; }
    }
}
