using System;
using System.Collections.Generic;

namespace ZORI_KIDS_KG.Models
{
    public partial class ParinteCopil
    {
        public int Id { get; set; }
        public int? ParinteId { get; set; }
        public int? CopilId { get; set; }

        public virtual Copil Copil { get; set; }
        public virtual Parinte Parinte { get; set; }
    }
}
