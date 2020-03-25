using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary
{
    interface IDbEntity
    {
        [Key]
        long? Id {get; set;}
    }
}
 