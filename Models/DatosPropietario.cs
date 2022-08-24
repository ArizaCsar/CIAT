using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CIAT.Models
{
    public partial class DatosPropietario
    {
        public DatosPropietario()
        {
            UbicacionesGanado = new HashSet<UbicacionesGanado>();
        }

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string NumeroCelular { get; set; }

        public virtual ICollection<UbicacionesGanado> UbicacionesGanado { get; set; }
    }
}
