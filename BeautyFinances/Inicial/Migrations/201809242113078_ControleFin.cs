namespace Inicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ControleFin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ControleFins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IdServico = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        valoracrescimo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        valortotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ControleFins");
        }
    }
}
