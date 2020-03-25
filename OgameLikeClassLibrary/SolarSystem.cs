using System;
using System.Collections.Generic;
using System.Text;

namespace OgameLikeClassLibrary
{
    public class SolarSystem : IDbEntity
    {
        public long? Id { get; set; }
        [MinLength(5), MaxLength(20)]
        public string Name {get; set;}
        List<Planet> Planets { get; set; }
    }
}
