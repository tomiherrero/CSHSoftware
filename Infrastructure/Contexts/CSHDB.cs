using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Contexts
{
    public class CSHDB: DbContext
    {
        public CSHDB(DbContextOptions<CSHDB> options): base(options)
        {

        }
        DbSet<TipoUsuarioModels> TipoUsuario { get; set; }
        DbSet<UsuarioModels> Usuario { get; set; }
        DbSet<VeterinariosModels> Veterinario { get; set; }
    }
}
