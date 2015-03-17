namespace Simpress.CodeFirst.FluentApi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionaCampoFabricante : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_CLIENTE", name: "Codigo", newName: "ID_CLIENTE");
            AddColumn("dbo.TB_PRODUTO", "NM_FABRICANTE", c => c.String(nullable: false, maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_PRODUTO", "NM_FABRICANTE");
            RenameColumn(table: "dbo.TB_CLIENTE", name: "ID_CLIENTE", newName: "Codigo");
        }
    }
}
