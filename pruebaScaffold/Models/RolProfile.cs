using System;
using System.Collections.Generic;

#nullable disable

namespace pruebaScaffold.Models
{
    public partial class RolProfile
    {
        public int RpId { get; set; }
        public int RolId { get; set; }
        public int ProfileId { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
