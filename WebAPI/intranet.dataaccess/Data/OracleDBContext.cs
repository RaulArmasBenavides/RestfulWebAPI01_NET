using intranet.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace intranet.infrastructure.Data
{
    public class OracleDBContext : DbContext
    {

        public OracleDBContext() : base("OracleDBContext") {
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Set a default schema for ALL tables
            modelBuilder.HasDefaultSchema("VENTA");
        }
        public DbSet<Alumno> Alumnos {get; set;}
    }
}