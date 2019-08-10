﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRequestSample.Models
{
    public class AdditionViewModel : IValidatableObject
    {
        [Required]
        public int FirstNumber
        {
            get; set;
        }

        [Required]
        public int SecondNumber
        {
            get; set;
        }

        [Required]
        public int Result
        {
            get; set;
        }

        public AdditionViewModel()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            Result = 0;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            return errors;
        }
    }
}