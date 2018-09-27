namespace Inicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OutrasClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comandas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        idServico = c.Int(nullable: false),
                        idCliente = c.Int(nullable: false),
                        servico = c.String(),
                        valorCo = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comandas");
        }
    }
}
