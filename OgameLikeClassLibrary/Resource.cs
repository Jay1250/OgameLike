using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary
{
    public class Resource : IDbEntity
    {
        public long? Id { get; set; }
        [MinLength(5), MaxLength(20)]
        public string Name { get; set; }
        public int? Level { get; set; }
        public DateTime LastUpdate { get; set; } = new DateTime();
    }
}
