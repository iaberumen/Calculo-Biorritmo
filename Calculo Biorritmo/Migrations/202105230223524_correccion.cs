namespace Calculo_Biorritmo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correccion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.accident", "fecha_accidente", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.accident", "fecha_accidente", c => c.DateTime());
        }
    }
}
