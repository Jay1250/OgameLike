using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary
{
    public class Planet : IDbEntity
    {
        public long? Id { get; set; }

        [MinLength(5), MaxLength(20)]
        public string Name { get; set; }
        public int? CaseNb { get; set; }
        List<Resource> Ressources { get; set; } = new List<Resource>();
        List<Building> Buildings { get; set; } = new List<Building>();
    }
}
