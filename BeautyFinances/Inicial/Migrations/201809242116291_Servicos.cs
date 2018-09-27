namespace Inicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Servicos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servicoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NomeServico = c.String(),
                        duracao = c.Double(nullable: false),
                        descricao = c.String(),
                        valorservico = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Servicoes");
        }
    }
}
