namespace Inicial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamposNovos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "UltimaVisita", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "UltimaVisita");
        }
    }
}
