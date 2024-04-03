using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiWtr.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // "Data Source=DESKTOP-VG2SPVV;Database=WTRdb;Persist Security Info=False;Integrated Security=true;Connect Timeout=60;Connection Lifetime=1;App=ApiWtr"
        }
    }

    /*
    Para ejecutar migraciones:
    Pararse en ApiWtr.Data
    Y ejecutar el comando
    dotnet ef migrations add XXXXXXXX --startup-project ../ApiWtr.Web/ApiWtr.Web.csproj
    Y si esta bien
    dotnet ef database update --startup-project ../ApiWtr.Web/ApiWtr.Web.csproj
    */
}