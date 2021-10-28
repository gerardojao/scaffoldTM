using System;
using System.Collections.Generic;

#nullable disable

namespace pruebaScaffold.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
