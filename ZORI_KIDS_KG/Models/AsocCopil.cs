using System;
using System.Collections.Generic;

namespace ZORI_KIDS_KG.Models
{
    public partial class AsocCopil
    {
        public int Id { get; set; }
        public int? AsocId { get; set; }
        public int? CopilId { get; set; }

        public virtual Asociatie Asoc { get; set; }
        public virtual Copil Copil { get; set; }
    }
}
