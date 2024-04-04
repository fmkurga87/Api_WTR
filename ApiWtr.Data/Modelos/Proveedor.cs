using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWtr.Data.Modelos
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string? RazonSocial { get; set; }
        public string Direccion { get; set; } = null!;
        public int Telefono { get; set; }
        public string Mail { get; set; } = null!;
        public string? Contacto { get; set; }
        public int? TelContacto { get; set; }
        public string? MailContacto { get; set; }
        public int IdLocalidad { get; set; }
        public int IdIva { get; set; }
        public int Cuit { get; set; }
        public string? NumCtaCte { get; set; }
        public decimal? Saldo { get; set; }
        public DateTime? FechaUltCompra { get; set; }
        public byte[] FechaAlta { get; set; } = null!;
        public DateTime? FechaModificacion { get; set; }
        public bool Baja { get; set; }
    }
}