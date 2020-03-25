using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary.Validator
{
    class NotNegativeValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
           int i =  Convert.ToInt32(value);
           return i > 0;
        }
    }
}
