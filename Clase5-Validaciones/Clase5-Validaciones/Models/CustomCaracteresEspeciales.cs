using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase5_Validaciones.Models
{
    public class CustomCaracteresEspeciales : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string texto = (string)value;
            if (String.IsNullOrEmpty(texto))
            {
                texto = "";
            }
            string regexp = $"^[a-zA-Z0-9.,;]*$";

            if ((Regex.Match(texto,regexp).Success))
            {
                return true;
            }
            return false;
        }
    }
}
