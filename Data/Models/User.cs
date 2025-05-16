using System.ComponentModel.DataAnnotations;

namespace inlämning1Tomasso.Data.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]


        [StringLength(50)]

        public string UserName { get; set; }

        [StringLength(50)]

        public string Émail { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [Phone]
        public int phone { get; set; }

       



    }
}
