using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZORI_KIDS_KG.Models
{
    public class MailSenderViewModel
    {
        [Required(ErrorMessage = "Camp obligatoriu!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu!")]
        public string Subiect { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu!")]
        [StringLength(10, ErrorMessage = "Avem nevoie de telefon dvs mobil in formatul 07XXXXXXXX", MinimumLength = 10)]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu!")]
        public string Message { get; set; }
    }
}
