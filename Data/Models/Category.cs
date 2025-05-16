using System.ComponentModel.DataAnnotations;

namespace inlämning1Tomasso.Data.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]

        
        [StringLength(50)]

        public string CategoryName { get; set; }
    }
}
