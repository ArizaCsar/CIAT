using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CIAT.Models
{
    public partial class UbicacionesGanado
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string TipoZona { get; set; }
        public int DatosPropietarioId { get; set; }
        public int ZonasDeforestadasId { get; set; }

        public virtual DatosPropietario DatosPropietario { get; set; }
        public virtual ZonasDeforestacion ZonasDeforestadas { get; set; }
    }
}
