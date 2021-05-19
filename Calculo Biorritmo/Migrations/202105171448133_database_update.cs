namespace Calculo_Biorritmo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database_update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.employee", "residuo_fisico", c => c.Single(nullable: false));
            AlterColumn("dbo.employee", "residuo_emocional", c => c.Single(nullable: false));
            AlterColumn("dbo.employee", "residuo_intelectual", c => c.Single(nullable: false));
            AlterColumn("dbo.employee", "residuo_intuicional", c => c.Single(nullable: false));
            DropColumn("dbo.employee", "anio_acc");
            DropColumn("dbo.employee", "mes_acc");
            DropColumn("dbo.employee", "dia_acc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.employee", "dia_acc", c => c.Int(nullable: false));
            AddColumn("dbo.employee", "mes_acc", c => c.Int(nullable: false));
            AddColumn("dbo.employee", "anio_acc", c => c.Int(nullable: false));
            AlterColumn("dbo.employee", "residuo_intuicional", c => c.Int(nullable: false));
            AlterColumn("dbo.employee", "residuo_intelectual", c => c.Int(nullable: false));
            AlterColumn("dbo.employee", "residuo_emocional", c => c.Int(nullable: false));
            AlterColumn("dbo.employee", "residuo_fisico", c => c.Int(nullable: false));
        }
    }
}
