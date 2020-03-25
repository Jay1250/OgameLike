using System;
using System.Collections.Generic;
using System.Text;

namespace OgameLikeClassLibrary
{
    class SolarSystem : IDbEntity
    {
        public long? Id { get; set; }
        public string Name {get; set;}
        List<Planet> Planets { get; set; }
    }
}
