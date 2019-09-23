using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZORI_KIDS_KG.Models
{
    public partial class Parinte
    {
        public Parinte()
        {
            AsocParinte = new HashSet<AsocParinte>();
            Asociatie = new HashSet<Asociatie>();
            Copil = new HashSet<Copil>();
            ParinteCopil = new HashSet<ParinteCopil>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "nume@exemplu.com")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Adresa email")]
        public string Email { get; set; }

        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}", ErrorMessage = "Alegeti o parola formata din cel putin 6 caractere, care sa contina cel putin o litera mica, o litera MARE, si 1 cifra.")]
        [Required(ErrorMessage = "Creati o parola puternica")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Avem nevoie de CNP-ul dvs.")]
        [StringLength(13, ErrorMessage = "CNP-ul dvs. este compus din 13 cifre. Completati cu atentie!", MinimumLength = 13)]
        [Display(Name = "CNP")]
        public string Cnp { get; set; }

        [Required(ErrorMessage = "Avem nevoie de numele dvs.")]
        [Display(Name = "Nume")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "Avem nevoie de prenumele dvs.")]
        [Display(Name = "Prenume")]
        public string Prenume { get; set; }

        [Required(ErrorMessage = "Avem nevoie de varsta dvs.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Data nasterii")]
        public DateTime Varsta { get; set; }

        [Required(ErrorMessage = "Avem nevoie de sexul dvs.")]
        [Display(Name ="Sex")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Avem nevoie de telefonul dvs.")]
        [StringLength(10, ErrorMessage = "Avem nevoie de telefon dvs mobil in formatul 07XXXXXXXX", MinimumLength = 10)]
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Avem nevoie de localitatea dvs.")]
        [Display(Name = "Localitate")]
        public string Localitate { get; set; }

        [Required(ErrorMessage = "Avem nevoie de judetul dvs.")]
        [Display(Name = "Judet")]        
        public string Judet { get; set; }

        [Required(ErrorMessage = "Avem nevoie de adresa dvs.")]
        [Display(Name = "Adresa")]
        public string Adresa { get; set; }

        [Required(ErrorMessage = "Camp obligatoriu!")]
        [Display(Name = "Roles Id")]
        public int? RolesId { get; set; }   
               
        public virtual Roles Roles { get; set; }

        //public virtual DashboardViewModel Dashboard { get; set; }
        public virtual ICollection<AsocParinte> AsocParinte { get; set; }
        public virtual ICollection<Asociatie> Asociatie { get; set; }
        public virtual ICollection<Copil> Copil { get; set; }
        public virtual ICollection<ParinteCopil> ParinteCopil { get; set; }
    }
}
