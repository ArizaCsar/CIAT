using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CIAT.Models
{
    public partial class ZonasDeforestacion
    {
        public ZonasDeforestacion()
        {
            UbicacionesGanado = new HashSet<UbicacionesGanado>();
        }

        public int Id { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string AreaDeforestacion { get; set; }

        public virtual ICollection<UbicacionesGanado> UbicacionesGanado { get; set; }
    }
}
