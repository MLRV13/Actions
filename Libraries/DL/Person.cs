using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DL
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }
        [Required(ErrorMessage = "The field Name is required.")]
        [StringLength(60)]
        [ConcurrencyCheck]
        public required string Name { get; set; }
        [Required(ErrorMessage = "The field eMail is required")]
        [StringLength (60)]
        [ConcurrencyCheck]
        public required string eMail { get; set; }
        [Required(ErrorMessage = "The field Country ID is required")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        [ConcurrencyCheck]
        public int CountryID { get; set; }
        [ForeignKey("CountryID")]
        public virtual Country? Country { get; set; }

    }
}
