namespace Calculo_Biorritmo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        curp = c.String(),
                        fecha_nacimiento = c.DateTime(nullable: false),
                        anio = c.Int(nullable: false),
                        mes = c.Int(nullable: false),
                        dia = c.Int(nullable: false),
                        fecha_accidente = c.DateTime(nullable: false),
                        anio_acc = c.Int(nullable: false),
                        mes_acc = c.Int(nullable: false),
                        dia_acc = c.Int(nullable: false),
                        dias_vividos = c.Int(nullable: false),
                        residuo_fisico = c.Int(nullable: false),
                        residuo_emocional = c.Int(nullable: false),
                        residuo_intelectual = c.Int(nullable: false),
                        residuo_intuicional = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employee");
        }
    }
}
