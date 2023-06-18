using System.ComponentModel.DataAnnotations;

namespace LOFI.Data
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }


        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
