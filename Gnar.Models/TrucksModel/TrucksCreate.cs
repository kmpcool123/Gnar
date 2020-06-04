﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnar.Models.TrucksModel
{
    public class TrucksCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "At least 2 characters.")]
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        [Display(Name = "Truck Name")]
        public string TruckName { get; set; }

        public decimal Size { get; set; }

        
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string Brand { get; set; }



        [Display(Name = "Pro-Model")]
        
        [MaxLength(100, ErrorMessage = "Woah there, too many characters.")]
        public string ProModel { get; set; }

        public decimal Weight { get; set; }

        public string Color { get; set; }



        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }


    }
}