using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZORI_KIDS_KG.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "nume@exemplu.com")]      
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Adresa email")]
        public string User { get; set; }

        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}", ErrorMessage = "Parola prea slaba.")]
        [Required(ErrorMessage = "Camp obligatoriu!")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }
    }
}
