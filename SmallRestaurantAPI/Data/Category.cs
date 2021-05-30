using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class Category 
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "Cannot exceed 50 chars.")]
        public string Name { get; set; }
    }
}
