using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("ClientIdentity")]
        public int ClientIdentity { get; set; }
    }
}
