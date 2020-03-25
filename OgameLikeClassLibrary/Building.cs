using OgameLikeClassLibrary.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary
{
    public abstract class Building : IDbEntity
    {
        public long? Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(5), MaxLength(20)]
        public string Name { get; set; }
        [NotNegativeValidator]
        public int? Level { get { return Level; } set {
                if (value < 0) { throw new ArgumentException("Level", "The value is negative"); }
                Level = value;
            } }
        [NotNegativeValidator]
        public int? CellNb { get; }
        public List<Resource> TotalCost { get => new List<Resource>(); }
        public List<Resource> NextCost { get => new List<Resource>(); }
    }
}
