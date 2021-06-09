namespace Calculo_Biorritmo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.employee", "curp", c => c.String(maxLength: 50));
            CreateIndex("dbo.employee", "curp", unique: true);
            DropColumn("dbo.employee", "fecha_accidente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.employee", "fecha_accidente", c => c.DateTime());
            DropIndex("dbo.employee", new[] { "curp" });
            AlterColumn("dbo.employee", "curp", c => c.String());
        }
    }
}
