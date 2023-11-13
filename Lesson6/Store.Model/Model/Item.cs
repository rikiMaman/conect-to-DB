using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Model.Model
{
    [Table("Item")]
    public class Item
    {
        [Key]
        [Required]
        public int Code { get; set; }

        [Required]
        [MaxLength(40)]
        public string? Name { get; set; }
        public string? Decription  { get; set; }

        public double Price { get; set; }

        public int Amount { get; set; }
        public string? Season { get; set; }
    }
}