﻿using intranet.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intranet.infrastructure.Data
{
    public class SQLContext : DbContext
    {
        public SQLContext() : base("SQLContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>().ToTable("Alumnos");
        }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
