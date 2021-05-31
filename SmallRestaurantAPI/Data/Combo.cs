﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class Combo 
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "Cannot exceed 50 chars.")]
        public string Name { get; set; }
        [StringLength(250, ErrorMessage = "Cannot Exceed 250 characters.")]
        public string Description { get; set; }
        public int ComboNumber { get; set; }
        public bool? ComboSizeOverride { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryID { get; set; }
        public Category Category { get; set; }


        [Required]
        [ForeignKey(nameof(Entree))]
        public int EntreeID { get; set; }
        public Entree Entree { get; set; }


        [ForeignKey(nameof(Side))]
        public int? SideID { get; set; }
        public Side Side { get; set; }


        [ForeignKey(nameof(Drink))]
        public int? DrinkID { get; set; }
        public Drink Drink { get; set; }


        [ForeignKey(nameof(Size))]
        public int? SizeID { get; set; }
        public Size Size { get; set; }
    }
}
