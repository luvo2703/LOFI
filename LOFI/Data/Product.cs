using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOFI.Data
{
    public class Product
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        //public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
