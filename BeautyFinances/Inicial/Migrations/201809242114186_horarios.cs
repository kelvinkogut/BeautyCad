namespace Inicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class horarios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        idFuncionario = c.Int(nullable: false),
                        horarioinicio = c.String(),
                        nomeFuncionario = c.String(),
                        nomeCliente = c.String(),
                        IdServico = c.Int(nullable: false),
                        tempo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Horarios");
        }
    }
}
