using OgameLikeClassLibrary.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary
{
    public class Resource : IDbEntity
    {
        public long? Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [MinLength(5), MaxLength(20)]
        public string Name { get; set; }
        [NotNegativeValidator]
        public int? LastQuantity
        {
            get { return LastQuantity; }
            set
            {
                if (value < 0) { throw new ArgumentException("LastQuantity", "The value is negative"); }
                LastQuantity = value;
            }
        }
        [LastUpdateCheckValidator]
        public DateTime LastUpdate { get; set; } = new DateTime();
    }
}
