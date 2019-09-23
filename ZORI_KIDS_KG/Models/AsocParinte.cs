using System;
using System.Collections.Generic;

namespace ZORI_KIDS_KG.Models
{ 
    public partial class AsocParinte
    {
        public int Id { get; set; }
        public int? AsociatieId { get; set; }
        public int? ParinteId { get; set; }

        public virtual Asociatie Asociatie { get; set; }
        public virtual Parinte Parinte { get; set; }
    }
}
