using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgameLikeClassLibrary.Validator
{
    class NotMoreThan4ResourcesValidator : ValidationAttribute
    {

        List<string> ressourceName = new List<string>();

        public override bool IsValid(object value)
        {
            ressourceName.Add("énergie");
            ressourceName.Add("oxygène");
            ressourceName.Add("acier");
            ressourceName.Add("uranium");
            var ressources = value as IEnumerable<Resource>;
            var nbrRessources = 0;
            Boolean isValid = true;

            if (ressources == null) return true;

            foreach (var ressource in ressources)
            {
                if (ressourceName.Contains(ressource.Name)){
                    ressourceName.Remove(ressource.Name);
                }
                else
                {
                    isValid = false;
                }
                nbrRessources++;
            }
            if (nbrRessources > 4 || !isValid) return false;
            return true;
        }
    }
}
