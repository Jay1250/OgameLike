using System;
using System.Collections.Generic;
using System.Text;

namespace OgameLikeClassLibrary
{
    class Planet : IDbEntity
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int? CaseNb { get; set; }
        List<Resource> Ressources { get; set; } = new List<Resource>();
        List<Building> Buildings { get; set; } = new List<Building>();
    }
}
