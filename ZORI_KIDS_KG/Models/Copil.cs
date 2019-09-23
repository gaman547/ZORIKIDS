using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZORI_KIDS_KG.Models
{
    public partial class Copil
    {
        public Copil()
        {
            AsocCopil = new HashSet<AsocCopil>();
            Asociatie = new HashSet<Asociatie>();
            ParinteCopil = new HashSet<ParinteCopil>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [StringLength(13, ErrorMessage = "CNP-ul este compus din 13 cifre. Completati cu atentie!", MinimumLength = 13)]
        [Display(Name = "CNP")]
        public string Cnp { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Nume")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Prenume")]
        public string Prenume { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [DataType(DataType.Date)]
        [Display(Name = "Data nasterii")]
        public DateTime Varsta { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Vorbeste?")]
        public string Vorbeste { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Nume Parinte/Tutore")]
        public int? ParinteId { get; set; }

        public virtual Parinte Parinte { get; set; }
        //public virtual DashboardViewModel Dashboard { get; set; }
        public virtual ICollection<AsocCopil> AsocCopil { get; set; }
        public virtual ICollection<Asociatie> Asociatie { get; set; }
        public virtual ICollection<ParinteCopil> ParinteCopil { get; set; }
    }
}
