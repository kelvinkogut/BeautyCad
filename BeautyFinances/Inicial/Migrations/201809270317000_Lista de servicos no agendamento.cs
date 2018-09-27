namespace Inicial.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Listadeservicosnoagendamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Horarios", "DataServico", c => c.DateTime(nullable: false));
            AddColumn("dbo.Servicoes", "Horarios_ID", c => c.Int());
            CreateIndex("dbo.Servicoes", "Horarios_ID");
            AddForeignKey("dbo.Servicoes", "Horarios_ID", "dbo.Horarios", "ID");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Servicoes", "Horarios_ID", "dbo.Horarios");
            DropIndex("dbo.Servicoes", new[] { "Horarios_ID" });
            DropColumn("dbo.Servicoes", "Horarios_ID");
            DropColumn("dbo.Horarios", "DataServico");
        }
    }
}
