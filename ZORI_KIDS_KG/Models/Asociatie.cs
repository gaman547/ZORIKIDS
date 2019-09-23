using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZORI_KIDS_KG.Models
{
    public partial class Asociatie
    {
        public Asociatie()
        {
            AsocCopil = new HashSet<AsocCopil>();
            AsocParinte = new HashSet<AsocParinte>();            
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]        
        [Display(Name = "Denumire")]
        public string Denumire { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]        
        [Display(Name = "Cod fiscal")]
        public string CodFiscal { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]        
        [Display(Name = "Nr Registrul Comertului")]
        public string NrRegCom { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [DataType(DataType.Date)]
        [Display(Name = "Data infintare")]
        public DateTime DataInfintare { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Cont bancar")]
        public string Iban { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Localitate")]
        public string Localitate { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Judet")]
        public string Judet { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Adresa")]
        public string Adresa { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Nume Parinte beneficiar")]
        public int? ParinteId { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu")]
        [Display(Name = "Nume Copil beneficiar")]
        public int? CopilId { get; set; }

        public virtual Copil Copil { get; set; }
        public virtual Parinte Parinte { get; set; }
        //public virtual DashboardViewModel Dashboard { get; set; }
        public virtual ICollection<AsocCopil> AsocCopil { get; set; }
        public virtual ICollection<AsocParinte> AsocParinte { get; set; }        
    }
}
