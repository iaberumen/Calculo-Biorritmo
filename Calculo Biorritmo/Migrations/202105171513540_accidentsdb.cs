namespace Calculo_Biorritmo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accidentsdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.accident",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        curp = c.String(),
                        fecha_accidente = c.DateTime(),
                        residuo_fisico = c.Single(nullable: false),
                        residuo_emocional = c.Single(nullable: false),
                        residuo_intelectual = c.Single(nullable: false),
                        residuo_intuicional = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropColumn("dbo.employee", "anio");
            DropColumn("dbo.employee", "mes");
            DropColumn("dbo.employee", "dia");
            DropColumn("dbo.employee", "residuo_fisico");
            DropColumn("dbo.employee", "residuo_emocional");
            DropColumn("dbo.employee", "residuo_intelectual");
            DropColumn("dbo.employee", "residuo_intuicional");
        }
        
        public override void Down()
        {
            AddColumn("dbo.employee", "residuo_intuicional", c => c.Single(nullable: false));
            AddColumn("dbo.employee", "residuo_intelectual", c => c.Single(nullable: false));
            AddColumn("dbo.employee", "residuo_emocional", c => c.Single(nullable: false));
            AddColumn("dbo.employee", "residuo_fisico", c => c.Single(nullable: false));
            AddColumn("dbo.employee", "dia", c => c.Int(nullable: false));
            AddColumn("dbo.employee", "mes", c => c.Int(nullable: false));
            AddColumn("dbo.employee", "anio", c => c.Int(nullable: false));
            DropTable("dbo.accident");
        }
    }
}
