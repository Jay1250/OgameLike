using System;
using System.Collections.Generic;
using System.Text;

namespace OgameLikeClassLibrary
{
    class Resource : IDbEntity
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
        public DateTime LastUpdate;
    }
}
