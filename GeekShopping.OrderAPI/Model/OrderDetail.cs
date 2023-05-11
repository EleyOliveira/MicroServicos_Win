using GeekShopping.OrderAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.OrderAPI.Model
{ 
    [Table("order_detail")]
    public class OrderDetail : BaseEntity
    {
        public long CartHeaderId { get; set; }

        [ForeignKey(nameof(CartHeaderId))]
        public virtual CartHeader CartHeader { get; set; }

        public long ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        [Column("count")]
        public int Count { get; set; }
    }
}
