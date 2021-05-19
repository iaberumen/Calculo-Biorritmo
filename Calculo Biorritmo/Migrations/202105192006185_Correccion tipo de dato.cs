namespace Calculo_Biorritmo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correcciontipodedato : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.accident", "residuo_fisico", c => c.Double(nullable: false));
            AlterColumn("dbo.accident", "residuo_emocional", c => c.Double(nullable: false));
            AlterColumn("dbo.accident", "residuo_intelectual", c => c.Double(nullable: false));
            AlterColumn("dbo.accident", "residuo_intuicional", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.accident", "residuo_intuicional", c => c.Single(nullable: false));
            AlterColumn("dbo.accident", "residuo_intelectual", c => c.Single(nullable: false));
            AlterColumn("dbo.accident", "residuo_emocional", c => c.Single(nullable: false));
            AlterColumn("dbo.accident", "residuo_fisico", c => c.Single(nullable: false));
        }
    }
}
