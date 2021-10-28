using System;
using System.Collections.Generic;

#nullable disable

namespace pruebaScaffold.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Users = new HashSet<User>();
        }

        public int IdRol { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RolProfile> RolProfiles { get; set; }
    }
}

   
