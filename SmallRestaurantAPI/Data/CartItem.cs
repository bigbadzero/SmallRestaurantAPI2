using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class CartItem
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(ApiUser))]
        [StringLength(450)]
        public string UserID { get; set; }
        public ApiUser ApiUser { get; set; }

        public virtual IList<SelectedEntree> SelectedEntrees { get; set; }

    }
}
