using System;
using System.Collections.Generic;

namespace ZORI_KIDS_KG.Models
{
    public partial class LinkRolesMenus
    {
        public int Id { get; set; }
        public int RolesId { get; set; }
        public int MenusId { get; set; }

        public virtual Menus Menus { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
