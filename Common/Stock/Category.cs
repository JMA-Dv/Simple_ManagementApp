
using System.ComponentModel.DataAnnotations;

namespace Common.Stock
{
    public class Category
    {

        public int IdCategory { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Name is mandatory")]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public bool Condition { get; set; }

    }
}
