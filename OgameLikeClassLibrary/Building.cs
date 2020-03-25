using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary
{
    public abstract class Building : IDbEntity
    {
        public long? Id { get; set; }
        [MinLength(5), MaxLength(20)]
        public string Name { get; set; }
        public int? level { get; set; }
        public abstract int? CellNb();
        public abstract List<Resource> TotalCost();
        public abstract List<Resource> NextCost(); 
    }
}
