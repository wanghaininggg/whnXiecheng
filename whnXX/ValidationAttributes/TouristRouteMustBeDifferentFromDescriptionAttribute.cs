﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using whnXX.Dtos;

namespace whnXX.ValidationAttributes
{
    public class TouristRouteMustBeDifferentFromDescriptionAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var touristRouteDto = (TouristRouteForMaipulationDto)validationContext.ObjectInstance;

            if (touristRouteDto.Title == touristRouteDto.Description)
            {
                return new ValidationResult("路线名称必须与路线描述不一样", new[] { "TouristRouteForCreationDto" });
            }
            return ValidationResult.Success;
        }
    }
}
