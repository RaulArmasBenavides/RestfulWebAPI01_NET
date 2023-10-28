namespace intranet.infrastructure.SQLMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        IdAlumno = c.Int(nullable: false, identity: true),
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
            DropTable("dbo.Alumnoes");
        }
    }
}
