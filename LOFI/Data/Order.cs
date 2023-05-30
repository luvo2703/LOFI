using System.ComponentModel.DataAnnotations;

namespace LOFI.Data
{
    public class Order
    {
        public int? Id { get; set; }
        [StringLength(450)]// chiều dài bằng userid trong bảng user dùng cho identity
        public string UserId { get; set; } = null!;
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }

        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
