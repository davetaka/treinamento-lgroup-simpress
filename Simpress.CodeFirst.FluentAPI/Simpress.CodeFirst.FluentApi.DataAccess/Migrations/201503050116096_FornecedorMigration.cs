namespace Simpress.CodeFirst.FluentApi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FornecedorMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_PRODUTO", name: "NM_PRODUTO", newName: "NM_FORNECEDOR");
            AddColumn("dbo.TB_PRODUTO", "Fornecedor", c => c.String());
            AlterColumn("dbo.TB_PRODUTO", "NM_FORNECEDOR", c => c.String(nullable: false, maxLength: 40, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_PRODUTO", "NM_FORNECEDOR", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropColumn("dbo.TB_PRODUTO", "Fornecedor");
            RenameColumn(table: "dbo.TB_PRODUTO", name: "NM_FORNECEDOR", newName: "NM_PRODUTO");
        }
    }
}
