using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFood.Models
{
    public class User:BaseMode
    {
        [Key]
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "LinkedInURL is required")]
        [DisplayName("LinkedInURL")]
        public string LinkedInUrl { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "PhoneNumber is required")]
        [DisplayName("PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
