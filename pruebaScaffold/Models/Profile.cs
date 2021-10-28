using System;
using System.Collections.Generic;

#nullable disable

namespace pruebaScaffold.Models
{
    public partial class Profile
    {
        public int IdProfile { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<RolProfile> RolProfiles { get; set; }
    }
}
