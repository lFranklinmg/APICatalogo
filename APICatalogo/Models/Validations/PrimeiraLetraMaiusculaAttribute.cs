﻿using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models.Validations
{
    public class PrimeiraLetraMaiusculaAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //ByPass ja validado na model
            if(value == null || string.IsNullOrEmpty(value.ToString()))
                return ValidationResult.Success;

            var primeiraLetra = value.ToString()[0].ToString();
            if (primeiraLetra != primeiraLetra.ToUpper())
                return new ValidationResult("A primeira letra deve ser maíscula");

            return ValidationResult.Success;
        }
    }
}
