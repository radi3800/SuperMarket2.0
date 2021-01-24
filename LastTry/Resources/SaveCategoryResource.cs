﻿using System.ComponentModel.DataAnnotations;

namespace LastTry.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}