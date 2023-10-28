namespace intranet.infrastructure.SQLMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumnos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Alumnos", newName: "Alumnoes");
        }
    }
}
