namespace Inicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ControleFin1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Funcao = c.String(),
                        nome = c.String(),
                        dtaNascimento = c.DateTime(nullable: false),
                        endereco = c.String(),
                        isAva = c.Int(nullable: false),
                        telefone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funcionarios");
        }
    }
}
