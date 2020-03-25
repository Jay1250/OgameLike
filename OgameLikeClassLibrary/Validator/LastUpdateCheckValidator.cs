using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary.Validator
{
    class LastUpdateCheckValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime <= DateTime.Now;
        }
    }
}
