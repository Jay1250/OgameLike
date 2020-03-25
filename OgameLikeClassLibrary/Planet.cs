using OgameLikeClassLibrary.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary
{
    public class Planet : IDbEntity
    {
        public long? Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(5), MaxLength(20)]
        public string Name { get; set; }
        [NotNegativeValidator]
        public int? CaseNb
        {
            get { return CaseNb; }
            set
            {
                if (value < 0) { throw new ArgumentException("CaseNb", "The value is negative"); }
                CaseNb = value;
            }
        }
        public virtual List<Building> Buildings { get; set; } = new List<Building>();
        [NotMoreThan4ResourcesValidator(ErrorMessage = "Incorrect list of ressources")]
        public List<Resource> Resources { get => new List<Resource>(); }
    }
}
