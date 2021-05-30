﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class CategoryDTO
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "Cannot exceed 50 chars.")]
        public string Name { get; set; }
        [StringLength(250, ErrorMessage = "Cannot Exceed 250 characters.")]
        public string Description { get; set; }
    }
}
