using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZORI_KIDS_KG.Models
{
    public class DashboardViewModel
    {
        //public DashboardViewModel()
        //{
        //    Asociatie = new HashSet<Asociatie>();
        //    Parinte = new HashSet<Parinte>();
        //    Copil = new HashSet<Copil>();
        //}

        //[Key]
        //public int Id { get; set; }

        public int copil_count { get; set; }

        public int parinte_count { get; set; }

        public int asociatie_count { get; set; }

        public int admin_count { get; set; }

        //public virtual ICollection<Asociatie> Asociatie { get; set; }
        //public virtual ICollection<Parinte> Parinte { get; set; }
        //public virtual ICollection<Copil> Copil { get; set; }
    }
}
