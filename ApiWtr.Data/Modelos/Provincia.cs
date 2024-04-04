using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWtr.Data.Modelos
{
    public class Provincia
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Codigo { get; set; }
        public bool Borrado { get; set; }
        public ICollection<Localidad>? Localidades { get; set; }
    }
}