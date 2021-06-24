using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class ItemCategoryDTO
    {
        public int ID { get; set; }


        [ForeignKey(nameof(Item))]
        public int ItemID { get; set; }
        public Item Item { get; set; }


        [ForeignKey(nameof(Category))]
        public int CategoryID { get; set; }
        public Category Category { get; set; }


    }
}
