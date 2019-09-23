using System;
using System.Collections.Generic;

namespace ZORI_KIDS_KG.Models
{ 
    public partial class Roles
    {
        public Roles()
        {
            Admins = new HashSet<Admins>();
            LinkRolesMenus = new HashSet<LinkRolesMenus>();
            Parinte = new HashSet<Parinte>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Admins> Admins { get; set; }
        public virtual ICollection<LinkRolesMenus> LinkRolesMenus { get; set; }
        public virtual ICollection<Parinte> Parinte { get; set; }
    }
}
