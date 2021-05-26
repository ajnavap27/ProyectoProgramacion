using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoProgramacionAN.Models;


namespace ProyectoProgramacionAN.Context
{
    public class AsistenciaBaseDatosContext : DbContext
    {
        public AsistenciaBaseDatosContext(DbContextOptions<AsistenciaBaseDatosContext> options) : base(options)
        {

        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
