using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace DL
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryID { get; set; }
        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(60)]
        [DisplayName("Country Name")]
        public required string Name { get; set; }
    }
}
