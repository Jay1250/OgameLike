using System;
using System.Collections.Generic;
using System.Text;

namespace OgameLikeClassLibrary
{
    abstract class Building : IDbEntity
    {
        public long? Id { get; set; }
        public string name { get; set; }
        public int? level { get; set; }
        public abstract int? CellNb();
        public abstract List<Resource> TotalCost();
        public abstract List<Resource> NextCost(); 
    }
}
