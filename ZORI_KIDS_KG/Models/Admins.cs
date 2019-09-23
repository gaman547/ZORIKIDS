using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZORI_KIDS_KG.Models
{
    public partial class Admins
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nume complet obligatoriu!")]
        [Display(Name = "Nume complet")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Adresa Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu!")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu!")]
        [Display(Name = "Roles Id")]
        public int? RolesId { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
