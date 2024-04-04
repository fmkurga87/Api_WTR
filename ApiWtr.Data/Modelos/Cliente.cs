using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWtr.Data.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Telefono { get; set; }
        public string Direccion { get; set; } = null!;
        public string? Mail { get; set; }
        public int DniCuit { get; set; }
        public int IdIva { get; set; }
        public int IdLocalidad { get; set; }
        public int? IdReparto { get; set; }
        public int? IdZona { get; set; }
        public bool Baja { get; set; }
        public bool Bloqueado { get; set; }
        public byte[] FechaAlta { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}