namespace Simpress.CodeFirst.FluentApi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FornecedorCorrecaoMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_PRODUTO", name: "NM_FORNECEDOR", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.TB_PRODUTO", name: "Fornecedor", newName: "NM_FORNECEDOR");
            RenameColumn(table: "dbo.TB_PRODUTO", name: "__mig_tmp__0", newName: "NM_PRODUTO");
            AlterColumn("dbo.TB_PRODUTO", "NM_PRODUTO", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.TB_PRODUTO", "NM_FORNECEDOR", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_PRODUTO", "NM_FORNECEDOR", c => c.String());
            AlterColumn("dbo.TB_PRODUTO", "NM_PRODUTO", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            RenameColumn(table: "dbo.TB_PRODUTO", name: "NM_PRODUTO", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.TB_PRODUTO", name: "NM_FORNECEDOR", newName: "Fornecedor");
            RenameColumn(table: "dbo.TB_PRODUTO", name: "__mig_tmp__0", newName: "NM_FORNECEDOR");
        }
    }
}
