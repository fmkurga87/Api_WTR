using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWtr.Data.Modelos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiWtr.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }

    /*
    Para ejecutar migraciones:
    Pararse en ApiWtr.Data
    Y ejecutar el comando
    dotnet ef migrations add XXXXXXXX --startup-project ../ApiWtr.Web/ApiWtr.Web.csproj
    Y si esta bien
    dotnet ef database update --startup-project ../ApiWtr.Web/ApiWtr.Web.csproj
    */

    // "Data Source=DESKTOP-VG2SPVV;Database=WTRdb;Persist Security Info=False;Integrated Security=true;Connect Timeout=60;Connection Lifetime=1;App=ApiWtr"
}