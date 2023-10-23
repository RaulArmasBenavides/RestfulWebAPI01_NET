using intranet.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace intranet.WebAPI.Data
{
    public class OracleDBContext : DbContext
    {

        public OracleDBContext() : base("OracleDbContext") {
        }

        public DbSet<Alumno> Alumnos {get; set;}
    }
}