namespace intranet.infrastructure.OracleMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "VENTA.Alumnoes",
                c => new
                    {
                        IdAlumno = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        ApePatAlumno = c.String(),
                        ApeMatAlumno = c.String(),
                        NomAlumno = c.String(),
                        DNI = c.String(),
                        CodigoAlu = c.String(),
                        TelAlumno = c.String(),
                        EmailAlumno = c.String(),
                        DirAlumno = c.String(),
                        Tipo = c.String(),
                        Carrera = c.String(),
                    })
                .PrimaryKey(t => t.IdAlumno);
            
        }
        
        public override void Down()
        {
            DropTable("VENTA.Alumnoes");
        }
    }
}
