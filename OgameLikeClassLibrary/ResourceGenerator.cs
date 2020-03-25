using System;
using System.Collections.Generic;
using System.Text;

namespace OgameLikeClassLibrary
{
    public abstract class ResourceGenerator : Building
    {
        public List<Resource> ResourceBySecond { get => new List<Resource>(); }
    }
}
