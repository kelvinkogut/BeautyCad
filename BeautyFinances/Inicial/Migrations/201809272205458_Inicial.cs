namespace Inicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        sexo = c.String(),
                        nascimento = c.DateTime(nullable: false),
                        telefone = c.String(),
                        endereco = c.String(),
                        ciccgc = c.String(),
                        UltimaVisita = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        idFuncionario = c.Int(nullable: false),
                        DataServico = c.DateTime(nullable: false),
                        horarioinicio = c.String(),
                        nomeFuncionario = c.String(),
                        idCliente = c.Int(nullable: false),
                        IdServico = c.Int(nullable: false),
                        tempo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
            CreateTable(
                "dbo.ServicoHorarios",
                c => new
                    {
                        Horarios_ID = c.Int(nullable: false),
                        Servico_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Horarios_ID, t.Servico_ID })
                .ForeignKey("dbo.Horarios", t => t.Horarios_ID, cascadeDelete: true)
                .ForeignKey("dbo.Servicoes", t => t.Servico_ID, cascadeDelete: true)
                .Index(t => t.Horarios_ID)
                .Index(t => t.Servico_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServicoHorarios", "Servico_ID", "dbo.Servicoes");
            DropForeignKey("dbo.ServicoHorarios", "Horarios_ID", "dbo.Horarios");
            DropIndex("dbo.ServicoHorarios", new[] { "Servico_ID" });
            DropIndex("dbo.ServicoHorarios", new[] { "Horarios_ID" });
            DropTable("dbo.ServicoHorarios");
            DropTable("dbo.Servicoes");
            DropTable("dbo.Horarios");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.ControleFins");
            DropTable("dbo.Comandas");
            DropTable("dbo.Clientes");
        }
    }
}
