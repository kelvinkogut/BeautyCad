namespace Inicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteraçãodamodelagenda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Horarios", "idCliente", c => c.Int(nullable: false));
            DropColumn("dbo.Horarios", "nomeCliente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Horarios", "nomeCliente", c => c.String());
            DropColumn("dbo.Horarios", "idCliente");
        }
    }
}
