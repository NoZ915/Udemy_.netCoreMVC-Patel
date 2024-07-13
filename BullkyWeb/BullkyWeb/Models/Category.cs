using System.ComponentModel.DataAnnotations;

namespace BullkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Category__Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
