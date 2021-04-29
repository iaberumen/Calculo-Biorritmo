namespace Calculo_Biorritmo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dayslivingchange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.employee", "fecha_accidente", c => c.DateTime());
            DropColumn("dbo.employee", "dias_vividos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.employee", "dias_vividos", c => c.Int(nullable: false));
            AlterColumn("dbo.employee", "fecha_accidente", c => c.DateTime(nullable: false));
        }
    }
}
